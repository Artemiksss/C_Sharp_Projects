namespace Lab5.Infrastructure.DataAccess;

public class CheckingBalance
{
    private int _sum;
    public CheckingBalance(int startSum)
    {
        _sum = startSum;
    }

    public int GetSum => _sum;

    public void AddMoney(int sum)
    {
        _sum += sum;
    }

    public void WithdrawMoney(int sum)
    {
        _sum -= sum;
    }
}