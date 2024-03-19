using Lab5.Infrastructure.DataAccess.Migrations;
using Lab5.Presentation.Console;

namespace Lab5;

public static class Program
{
    public static void Main()
    {
        string connectionString = "Host=localhost; port=5433; user id=postgres; Password=Zh.a3254875; Database=postgres";
        var table = new InitialMigration(connectionString);
        table.CreatureTableAccounts();
        table.CreatureTableOperationHistory();
        var system = new ATMSystem(connectionString);
        system.Start();
    }
}