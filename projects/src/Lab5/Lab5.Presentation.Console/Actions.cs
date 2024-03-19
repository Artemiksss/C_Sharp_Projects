using System.Data;
using Lab5.Application;
using Lab5.Infrastructure.DataAccess.Actions;
using Lab5.Presentation.Console.Account;
using Npgsql;

namespace Lab5.Presentation.Console;

public class Actions
{
    private string _adminPassword = "12345";
    private ActionsDatabaseAccounts _databaseAccounts;
    private string _commandString;
    private UserContext _context;

    public Actions(string commandString)
    {
        _databaseAccounts = new ActionsDatabaseAccounts(commandString);
        _commandString = commandString;
        _context = new UserContext(new BaseState());
    }

    public void CreateNewAccount()
    {
        System.Console.WriteLine("Enter your name: ");
        string? name = System.Console.ReadLine();
        System.Console.WriteLine("Come up with a password: ");
        string? password = System.Console.ReadLine();
        if ((name is null) || (password is null)) throw new DataException();
        _databaseAccounts.AddAccount(name, password);
    }

    public void LoginUser()
    {
        System.Console.WriteLine("Enter your ID: ");
        bool id = int.TryParse(System.Console.ReadLine(), out int personId);
        if (id)
        {
            if (_databaseAccounts.FindUser(personId))
            {
                System.Console.WriteLine("Enter the user password: ");
                string? password = System.Console.ReadLine();
                using var connection = new NpgsqlConnection(_commandString);
                connection.Open();
                using var findUserCommand = new NpgsqlCommand();
                findUserCommand.Connection = connection;
                findUserCommand.CommandText = "SELECT * FROM BankAccounts WHERE userID = @UserIdToFind;";
                findUserCommand.Parameters.AddWithValue("@UserIdToFind", personId);
                using NpgsqlDataReader reader = findUserCommand.ExecuteReader();
                if (reader.Read())
                {
                    string userPassword = reader.GetString(reader.GetOrdinal("password"));
                    if (userPassword == password)
                    {
                        System.Console.WriteLine("Select the type of operation: ");
                        System.Console.WriteLine("--- 1. Money transactions: ");
                        System.Console.WriteLine("--- 2. Other operations: ");
                        System.Console.WriteLine("Enter number: ");
                        string? number = System.Console.ReadLine();
                        if (number == "1")
                        {
                            _context.TransitionTo(new UserMoneyTransactions());
                            new UserInterface(_context).RunUser(personId);
                        }

                        if (number == "2")
                        {
                            _context.TransitionTo(new UserSimpleOperations());
                            new UserInterface(_context).RunUser(personId);
                        }
                    }
                }
            }
        }
    }

    public void LoginAdmin()
    {
        System.Console.WriteLine("Enter the administrator password: ");
        string? password = System.Console.ReadLine();
        if (_adminPassword == password)
        {
            System.Console.WriteLine("Select the type of operation: ");
            System.Console.WriteLine("--- 1. Money transactions: ");
            System.Console.WriteLine("--- 2. Other operations: ");
            System.Console.WriteLine("Enter number: ");
            string? number = System.Console.ReadLine();
            if (number == "1")
            {
                _context.TransitionTo(new AdminMoneyTransactions());
                new UserInterface(_context).RunAdmin();
            }

            if (number == "2")
            {
                _context.TransitionTo(new AdminSimpleOperations());
                new UserInterface(_context).RunAdmin();
            }
        }
    }

    public void ChangeTheAdministratorPassword(string newPassword)
    {
        System.Console.WriteLine("Enter the administrator password: ");
        string? password = System.Console.ReadLine();
        if (_adminPassword == password)
        {
            _adminPassword = newPassword;
        }
    }
}