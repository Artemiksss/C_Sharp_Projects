namespace Lab5.Application;

public class UserContext : IUserContext
{
    private UserStates _state;
    public UserContext(UserStates state)
    {
        _state = state;
    }

    public UserStates GetUserStates => _state;

    public void TransitionTo(UserStates state)
    {
        this._state = state;
        this._state.SetContext(this);
    }

    public void RequestDeleteUser(int userId)
    {
       this._state.DeleteUser(userId);
    }

    public void RequestTopUpYourBalance(int userId, int sum)
    {
        this._state.TopUpYourBalance(userId, sum);
    }

    public void RequestWithdrawMoney(int userId, int sum)
    {
        this._state.WithdrawMoney(userId, sum);
    }

    public void RequestChangeYourPassword(int userId, string newPassword)
    {
        this._state.ChangeYourPassword(userId, newPassword);
    }

    public int RequestGetBalance(int userId)
    {
        return this._state.GetBalance(userId);
    }
}