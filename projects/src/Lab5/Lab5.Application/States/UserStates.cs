namespace Lab5.Application;

public abstract class UserStates
{
    public UserContext? Context { get; protected set; }

    public void SetContext(UserContext context)
    {
        this.Context = context;
    }

    public abstract void DeleteUser(int userId);
    public abstract void TopUpYourBalance(int userId, int sum);
    public abstract void WithdrawMoney(int userId, int sum);
    public abstract void ChangeYourPassword(int userId, string newPassword);
    public abstract int GetBalance(int userId);
}