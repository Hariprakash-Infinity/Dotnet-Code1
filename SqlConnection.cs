using System;
public class SqlConnection : DbConnection
{
    public SqlConnection() {}
    public SqlConnection(string _connectionString) : base(_connectionString)
    {

    }
    public override void OpenConnection()
    {
        System.Console.WriteLine("SQLConnection is opened!");
    }
    public override void CloseConnection()
    {
        System.Console.WriteLine("SQLConnection is closed!");
    }
}