using Lab5.Infrastructure.DataAccess.Actions;

namespace Lab5.Application;

public class UserService
{
    private ActionsDatabaseAccounts _databaseAccounts;

    public UserService(string connectString)
    {
        _databaseAccounts = new ActionsDatabaseAccounts(connectString);
    }

    public void LoggingUser(string name, string password)
    {
        _databaseAccounts.AddAccount(name, password);
    }
}