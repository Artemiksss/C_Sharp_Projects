using Lab5.Application.Abstractions.Repository;
using Lab5.Application.Exception;
using Lab5.Application.Models;
using Lab5.Infrastructure.DataAccess.Actions;
using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Repositories;

public class UserRepository : IUserRepository
{
    private ActionsDatabaseAccounts _databaseAccounts;
    private string _stringConnect;

    public UserRepository(string stringConnect)
    {
        _databaseAccounts = new ActionsDatabaseAccounts(stringConnect);
        _stringConnect = stringConnect;
    }

    public User? FindUser(string username, int id)
    {
        if (_databaseAccounts.FindUser(id))
        {
            using var connection = new NpgsqlConnection(_stringConnect);
            connection.Open();
            using var findUserCommand = new NpgsqlCommand();
            findUserCommand.Connection = connection;
            findUserCommand.CommandText = "SELECT * FROM BankAccounts WHERE userID = @id;";
            findUserCommand.Parameters.AddWithValue("@UserIdToFind", id);
            using NpgsqlDataReader reader = findUserCommand.ExecuteReader();
            if (reader.Read())
            {
                int foundUserId = reader.GetInt32(reader.GetOrdinal("userID"));
                string foundUserName = reader.GetString(reader.GetOrdinal("name"));
                return new User(
                    Id: foundUserId,
                    Username: foundUserName,
                    Role: reader.GetFieldValue<UserRoles>(2));
            }
        }

        throw new UserInDataBaseException();
    }
}