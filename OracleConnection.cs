using System;
public class OracleConnection : DbConnection
{
    public OracleConnection() {}
    public OracleConnection(string _connectionString) : base(_connectionString)
    {

    }
    public override void OpenConnection()
    {
        System.Console.WriteLine("ORACLEConnection is Opened!");
    }
    public override void CloseConnection()
    {
        System.Console.WriteLine("ORACLEConnection is closed!");
    }
}