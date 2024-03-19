using System.Data;
using Lab5.Application;

namespace Lab5.Presentation.Console.Account;

public class UserInterface
{
    private UserContext _context;

    public UserInterface(UserContext context)
    {
        _context = context;
    }

    public void RunUser(int userId)
    {
        System.Console.WriteLine("Select an action: ");
        if (_context.GetUserStates.GetType() == typeof(UserMoneyTransactions))
        {
            System.Console.WriteLine("--- 1. Top up your balance.");
            System.Console.WriteLine("--- 2. Withdraw from the account.");
        }

        if (_context.GetUserStates.GetType() == typeof(UserSimpleOperations))
        {
            System.Console.WriteLine("--- 3. Change your password.");
            System.Console.WriteLine("--- 4. Balance.");
        }

        System.Console.WriteLine("Enter number: ");
        string? number = System.Console.ReadLine();
        if (number == "1") TopUpYourBalance(userId);
        if (number == "2") WithdrawMoney(userId);
        if (number == "3") ChangeYourPassword(userId);
        if (number == "4") GetBalance(userId);
    }

    public void RunAdmin()
    {
        System.Console.WriteLine("Select an action: ");
        if (_context.GetUserStates.GetType() == typeof(AdminMoneyTransactions))
        {
            System.Console.WriteLine("--- 1. Top up your balance.");
            System.Console.WriteLine("--- 2. Withdraw from the account.");
        }

        if (_context.GetUserStates.GetType() == typeof(AdminSimpleOperations))
        {
            System.Console.WriteLine("--- 3. Change your password.");
            System.Console.WriteLine("--- 4. Delete user.");
            System.Console.WriteLine("--- 5. Balance.");
        }

        System.Console.WriteLine("Enter number: ");
        string? number = System.Console.ReadLine();
        System.Console.WriteLine("Enter user ID: ");
        bool id = int.TryParse(System.Console.ReadLine(), out int userId);
        if (id)
        {
            if (number == "1") TopUpYourBalance(userId);
            if (number == "2") WithdrawMoney(userId);
            if (number == "3") ChangeYourPassword(userId);
            if (number == "4") DeleteUser(userId);
            if (number == "5") GetBalance(userId);
        }
    }

    private void DeleteUser(int userId)
    {
        _context.RequestDeleteUser(userId);
    }

    private void TopUpYourBalance(int userId)
    {
        System.Console.WriteLine("Enter sum:");
        bool sum = int.TryParse(System.Console.ReadLine(), out int number);
        if (sum)
        {
            _context.RequestTopUpYourBalance(userId, number);
        }
    }

    private void WithdrawMoney(int userId)
    {
        System.Console.WriteLine("Enter sum:");
        bool sum = int.TryParse(System.Console.ReadLine(), out int number);
        if (sum)
        {
            _context.RequestWithdrawMoney(userId, number);
        }
    }

    private void ChangeYourPassword(int userId)
    {
        System.Console.WriteLine("Enter new password:");
        string? newPassword = System.Console.ReadLine();
        if (newPassword is null) throw new DataException();
        _context.RequestChangeYourPassword(userId, newPassword);
    }

    private void GetBalance(int userId)
    {
        System.Console.WriteLine($"Balance: {_context.RequestGetBalance(userId)}");
    }
}