using Lab5.Application.Exception;

namespace Lab5.Application;

public class BaseState : UserStates
{
    public override void DeleteUser(int userId)
    {
        throw new StateException();
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
        throw new StateException();
    }

    public override int GetBalance(int userId)
    {
        throw new StateException();
    }
}