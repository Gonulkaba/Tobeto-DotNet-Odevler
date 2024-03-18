using System;

class Program
{
    static void Main(string[] args)
    {
        // Polimorfizm
        DatabaseManager sqlServerManager = new SqlServerDatabaseManager();
        DatabaseManager mySqlManager = new MySqlDatabaseManager();

        sqlServerManager.Connect();
        sqlServerManager.ExecuteQuery("SELECT * FROM Customers");

        mySqlManager.Connect();
        mySqlManager.ExecuteQuery("SELECT * FROM Products");

        Console.ReadLine();
    }
}
class DatabaseManager
{
    public virtual void Connect()
    {
        Console.WriteLine("Veritabanına bağlanılıyor.");
    }

    public virtual void ExecuteQuery(string query)
    {
        Console.WriteLine($"Sorgu çalıştırılıyor: {query}");
    }
}

class SqlServerDatabaseManager : DatabaseManager
{
    public override void Connect()
    {
        Console.WriteLine("SQL Server veritabanına bağlanılıyor.");
    }

    public override void ExecuteQuery(string query)
    {
        Console.WriteLine($"SQL Server sorgusu çalıştırılıyor: {query}");
    }
}

class MySqlDatabaseManager : DatabaseManager
{
    public override void Connect()
    {
        Console.WriteLine("MySQL veritabanına bağlanılıyor.");
    }

    public override void ExecuteQuery(string query)
    {
        Console.WriteLine($"MySQL sorgusu çalıştırılıyor: {query}");
    }
}


