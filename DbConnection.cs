using System;
public abstract class DbConnection
{
    public string ConnectionString { get; set; }
    public TimeSpan Timeout { get; set; }

    public DbConnection() {}
    public DbConnection(string _connectionString)
    {
        if((_connectionString=="") || (_connectionString==null))
        {
            throw new InvalidOperationException();
        }
        ConnectionString = _connectionString;
        System.Console.WriteLine("ConnectionString is Valid");
    }

    public abstract void OpenConnection();
    public abstract void CloseConnection();
}