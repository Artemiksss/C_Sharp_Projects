namespace Lab5.Application;

public interface IUserContext
{
    public void TransitionTo(UserStates state);
    public void RequestDeleteUser(int userId);
    public int RequestGetBalance(int userId);
    public void RequestTopUpYourBalance(int userId, int sum);
    public void RequestWithdrawMoney(int userId, int sum);
    public void RequestChangeYourPassword(int userId, string newPassword);
}