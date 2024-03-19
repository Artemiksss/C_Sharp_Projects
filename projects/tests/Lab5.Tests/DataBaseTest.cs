using Lab5.Infrastructure.DataAccess.Actions;
using Xunit;
namespace Itmo.ObjectOrientedProgramming.Lab5.Tests;

public class DataBaseTest
{
    [Fact]
    public void AddToDataBaseTest()
    {
        string connectionString = "Host=localhost; port=5433; user id=postgres; Password=Zh.a3254875; Database=postgres";
        var dataBase = new ActionsDatabaseAccounts(connectionString, 1, 1000);
        int testUserId = 123;
        int amountOfTheDeposit = 500;
        int withdrawalAmount = 300;
        int balanceAfterReplenishment = 1500;
        int balanceAfterWithdrawal = 1200;
        dataBase.TopUpYourAccount(testUserId, amountOfTheDeposit);
        Assert.Equal(dataBase.GetBalance(testUserId), balanceAfterReplenishment);
        dataBase.WithdrawMoney(testUserId, withdrawalAmount);
        Assert.Equal(dataBase.GetBalance(testUserId), balanceAfterWithdrawal);
    }
}