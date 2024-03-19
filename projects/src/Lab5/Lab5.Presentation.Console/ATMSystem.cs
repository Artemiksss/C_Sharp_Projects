namespace Lab5.Presentation.Console;

public class ATMSystem
{
    private Actions _actions;

    public ATMSystem(string memoryAtm)
    {
        _actions = new Actions(memoryAtm);
    }

    public void Start()
    {
       System.Console.WriteLine("------------------------------HELLO-------------------------------");
       System.Console.WriteLine("------------------------Welcome to the ATM------------------------");
       while (true)
       {
           System.Console.WriteLine("What do you want to do?");
           System.Console.WriteLine("--- 1. Log in to your account.");
           System.Console.WriteLine("--- 2. Create a new account.");
           System.Console.WriteLine("--- 3. Log in as an administrator");
           System.Console.WriteLine("Enter number: ");
           string? number = System.Console.ReadLine();
           if (number == "1")
           {
               _actions.LoginUser();
           }

           if (number == "2")
           {
               _actions.CreateNewAccount();
           }

           if (number == "3")
           {
               _actions.LoginAdmin();
           }

           if (number == "0") break;
       }
    }
}