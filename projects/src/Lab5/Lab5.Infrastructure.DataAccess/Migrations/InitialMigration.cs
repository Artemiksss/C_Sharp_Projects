using Npgsql;

namespace Lab5.Infrastructure.DataAccess.Migrations;

public class InitialMigration
{
    private string _sql;

    public InitialMigration(string sql)
    {
        _sql = sql;
    }

    public void CreatureTableAccounts()
    {
        var connection = new NpgsqlConnection(_sql);
        connection.Open();
        using var command = new NpgsqlCommand();
        command.Connection = connection;
        command.CommandText = "CREATE TABLE IF NOT EXISTS BankAccounts (userID serial PRIMARY KEY, name VARCHAR(255), password VARCHAR(255), amount DECIMAL);";
        command.ExecuteNonQuery();
        Console.WriteLine("The table was created successfully.");
    }

    public void CreatureTableOperationHistory()
    {
        var connection = new NpgsqlConnection(_sql);
        connection.Open();
        using var command = new NpgsqlCommand();
        command.Connection = connection;
        command.CommandText = "CREATE TABLE IF NOT EXISTS OperationHistory (userID INT, operation VARCHAR(255));";
        command.ExecuteNonQuery();
        Console.WriteLine("The table was created successfully.");
    }
}