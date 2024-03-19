using System.Security.Cryptography;
using Lab5.Application.Abstractions.Actions;
using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Actions;

public class ActionsDatabaseAccounts : IActionDatabaseAccount
{
    private string _sql;
    private int _testMode;
    private CheckingBalance _balance = new CheckingBalance(1000);

    public ActionsDatabaseAccounts(string sql)
    {
        _sql = sql;
    }

    public ActionsDatabaseAccounts(string sql, int test, int startAmount)
    {
        _sql = sql;
        _testMode = test;
        _balance = new CheckingBalance(startAmount);
    }

    public void AddAccount(string name, string password)
    {
        var connection = new NpgsqlConnection(_sql);
        connection.Open();
        using (var insertUserCommand = new NpgsqlCommand())
        {
            insertUserCommand.Connection = connection;
            insertUserCommand.CommandText = "INSERT INTO BankAccounts (userID, name, password, amount) VALUES (@ID, @UserName, @Password, @Amount);";
            insertUserCommand.Parameters.AddWithValue("@UserName", name);
            insertUserCommand.Parameters.AddWithValue("@ID", RandomNumberGenerator.GetInt32(10000));
            insertUserCommand.Parameters.AddWithValue("@Password", password);
            insertUserCommand.Parameters.AddWithValue("@Amount", 0);
            insertUserCommand.ExecuteNonQuery();
            Console.WriteLine("The user was added successfully.");
        }
    }

    public bool FindUser(int userId)
    {
        var connection = new NpgsqlConnection(_sql);
        connection.Open();
        using (var findUserCommand = new NpgsqlCommand())
        {
            findUserCommand.Connection = connection;
            findUserCommand.CommandText = "SELECT * FROM BankAccounts WHERE userID = @UserID;";
            findUserCommand.Parameters.AddWithValue("@UserID", userId);
            using (NpgsqlDataReader reader = findUserCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    public void DeleteUser(int userId)
    {
        var connection = new NpgsqlConnection(_sql);
        connection.Open();
        using (var deleteUserCommand = new NpgsqlCommand())
        {
            deleteUserCommand.Connection = connection;
            deleteUserCommand.CommandText = "DELETE FROM BankAccounts WHERE userID = (@UserIdToDelete)";
            deleteUserCommand.Parameters.AddWithValue("@UserIdToDelete", userId);
            int rowsAffected = deleteUserCommand.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                Console.WriteLine($"The user with the ID {userId} was deleted successfully.");
            }
            else
            {
                Console.WriteLine($"The user with the ID {userId} was not found.");
            }
        }
    }

    public void TopUpYourAccount(int userId, int sum)
    {
        if (_testMode == 1)
        {
            _balance.AddMoney(sum);
        }
        else
        {
            var connection = new NpgsqlConnection(_sql);
            connection.Open();
            using (var updateAmountCommand = new NpgsqlCommand())
            {
                updateAmountCommand.Connection = connection;
                updateAmountCommand.CommandText =
                    "UPDATE BankAccounts SET amount = amount + @AmountToAdd WHERE userID = @UserIdToUpdate;";
                updateAmountCommand.Parameters.AddWithValue("@AmountToAdd", sum);
                updateAmountCommand.Parameters.AddWithValue("@UserIdToUpdate", userId);
                int rowsAffected = updateAmountCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    using (var insertUserCommand = new NpgsqlCommand())
                    {
                        insertUserCommand.Connection = connection;
                        insertUserCommand.CommandText =
                            "INSERT INTO operationhistory (userID, operation) VALUES (@ID, @Operation);";
                        insertUserCommand.Parameters.AddWithValue("@ID", userId);
                        insertUserCommand.Parameters.AddWithValue("@Operation", "+" + sum);
                        insertUserCommand.ExecuteNonQuery();
                    }

                    Console.WriteLine($"The operation was completed successfully.");
                }
                else
                {
                    Console.WriteLine($"The user with the ID {userId} was not found.");
                }
            }
        }
    }

    public void WithdrawMoney(int userId, int sum)
    {
        if (_testMode == 1)
        {
            _balance.WithdrawMoney(sum);
        }
        else
        {
            var connection = new NpgsqlConnection(_sql);
            connection.Open();
            using (var updateAmountCommand = new NpgsqlCommand())
            {
                using var findUserCommand = new NpgsqlCommand();
                findUserCommand.Connection = connection;
                findUserCommand.CommandText = "SELECT * FROM BankAccounts WHERE userID = @UserIdToFind;";
                findUserCommand.Parameters.AddWithValue("@UserIdToFind", userId);
                using NpgsqlDataReader reader = findUserCommand.ExecuteReader();
                if (reader.Read())
                {
                    int accountSum = reader.GetInt32(reader.GetOrdinal("amount"));
                    connection.Close();
                    if (accountSum - sum >= 0)
                    {
                        var newConnection = new NpgsqlConnection(_sql);
                        newConnection.Open();
                        updateAmountCommand.Connection = newConnection;
                        updateAmountCommand.CommandText =
                            "UPDATE BankAccounts SET amount = amount - @AmountToSub WHERE userID = @UserIdToUpdate;";
                        updateAmountCommand.Parameters.AddWithValue("@AmountToSub", sum);
                        updateAmountCommand.Parameters.AddWithValue("@UserIdToUpdate", userId);
                        int rowsAffected = updateAmountCommand.ExecuteNonQuery();
                        newConnection.Close();

                        if (rowsAffected > 0)
                        {
                            var newConnectionOperation = new NpgsqlConnection(_sql);
                            newConnectionOperation.Open();
                            using (var insertUserCommand = new NpgsqlCommand())
                            {
                                insertUserCommand.Connection = newConnectionOperation;
                                insertUserCommand.CommandText =
                                    "INSERT INTO operationhistory (userID, operation) VALUES (@ID, @Operation);";
                                insertUserCommand.Parameters.AddWithValue("@ID", userId);
                                insertUserCommand.Parameters.AddWithValue("@Operation", "-" + sum);
                                insertUserCommand.ExecuteNonQuery();
                            }

                            Console.WriteLine("The operation was completed successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"The user with the ID {userId} was not found.");
                        }
                    }

                    Console.WriteLine("There is not enough money in the account");
                }
            }
        }
    }

    public void ChangePassword(int userId, string newPassword)
    {
        var connection = new NpgsqlConnection(_sql);
        connection.Open();
        using var updateAmountCommand = new NpgsqlCommand();
        updateAmountCommand.Connection = connection;
        updateAmountCommand.CommandText = "UPDATE BankAccounts SET password = @NewPassword WHERE userID = @UserIdToUpdate;";
        updateAmountCommand.Parameters.AddWithValue("@NewPassword", newPassword);
        updateAmountCommand.Parameters.AddWithValue("@UserIdToUpdate", userId);
        int rowsAffected = updateAmountCommand.ExecuteNonQuery();

        if (rowsAffected > 0)
        {
            Console.WriteLine($"The operation was completed successfully.");
        }
        else
        {
            Console.WriteLine($"The user with the ID {userId} was not found.");
        }
    }

    public int GetBalance(int userId)
    {
        if (_testMode == 1)
        {
            return _balance.GetSum;
        }
        else
        {
            var connection = new NpgsqlConnection(_sql);
            connection.Open();
            using (var updateAmountCommand = new NpgsqlCommand())
            {
                using var findUserCommand = new NpgsqlCommand();
                findUserCommand.Connection = connection;
                findUserCommand.CommandText = "SELECT * FROM BankAccounts WHERE userID = @UserIdToFind;";
                findUserCommand.Parameters.AddWithValue("@UserIdToFind", userId);
                using NpgsqlDataReader reader = findUserCommand.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetInt32(reader.GetOrdinal("amount"));
                }
            }

            return -1;
        }
    }
}