using Lab5.Application.Exception;
using Lab5.Infrastructure.DataAccess.Actions;

namespace Lab5.Application;

public class AdminSimpleOperations : UserStates
{
    private ActionsDatabaseAccounts _databaseAccounts = new ActionsDatabaseAccounts("Host=localhost; port=5433; user id=postgres; Password=Zh.a3254875; Database=postgres");
    public override void DeleteUser(int userId)
    {
        Console.WriteLine("Enter the ID of the user you want to delete:");
        _databaseAccounts.DeleteUser(userId);
    }

    public override void TopUpYourBalance(int userId, int sum)
    {
        throw new StateException();
    }

    public override void WithdrawMoney(int userId, int sum)
    {
        throw new StateException();
    }

    public override void ChangeYourPassword(int userId, string newPassword)
    {
        _databaseAccounts.ChangePassword(userId, newPassword);
    }

    public override int GetBalance(int userId)
    {
        return _databaseAccounts.GetBalance(userId);
    }
}