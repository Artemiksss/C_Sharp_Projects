using Lab5.Application.Exception;
using Lab5.Infrastructure.DataAccess.Actions;

namespace Lab5.Application;

public class AdminMoneyTransactions : UserStates
{
    private ActionsDatabaseAccounts _databaseAccounts = new ActionsDatabaseAccounts("Host=localhost; port=5433; user id=postgres; Password=Zh.a3254875; Database=postgres");

    public override void DeleteUser(int userId)
    {
        throw new StateException();
    }

    public override void TopUpYourBalance(int userId, int sum)
    {
        _databaseAccounts.TopUpYourAccount(userId, sum);
    }

    public override void WithdrawMoney(int userId, int sum)
    {
        _databaseAccounts.WithdrawMoney(userId, sum);
    }

    public override void ChangeYourPassword(int userId, string newPassword)
    {
        throw new StateException();
    }

    public override int GetBalance(int userId)
    {
        throw new StateException();
    }
}