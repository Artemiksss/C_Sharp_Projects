namespace Lab5.Application.Abstractions.Actions;

public interface IActionDatabaseAccount
{
    public void AddAccount(string name, string password);
    public bool FindUser(int userId);
    public void DeleteUser(int userId);
    public void TopUpYourAccount(int userId, int sum);
    public void WithdrawMoney(int userId, int sum);
    public void ChangePassword(int userId, string newPassword);
    public int GetBalance(int userId);
}