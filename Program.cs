using System;

namespace Dbconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DBCONNECTION - ABSTRACT");
            while(true)
            {
                System.Console.WriteLine("Enter 1 if you wish to continue else any other number to exit!");
                int Contin = Convert.ToInt32(Console.ReadLine());
                if(Contin.Equals(1))
                {
                    //break;
                }
                else
                {
                    break;
                }
                System.Console.WriteLine("Enter which DB to connect 1.SQL, 2.ORACLE");
                string Dbchoice = Console.ReadLine();
                //var ObjDb = new DbConnection();
                System.Console.WriteLine("ENter the Connection string");
                string ConnectionString = Console.ReadLine();
                try
                {
                    if (Dbchoice == "1")
                    {
                        var ObjDb = new SqlConnection(ConnectionString);
                        ObjDb.OpenConnection();
                        ObjDb.CloseConnection();
                    }
                    else if(Dbchoice == "2")
                    {
                        var ObjDb = new OracleConnection(ConnectionString);
                        ObjDb.OpenConnection();
                        ObjDb.CloseConnection();
                    }
                    else
                    {
                        System.Console.WriteLine("Enter a valid DB connection!");
                        continue;
                    }
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.Message);
                    continue;                    
                    //throw;
                }
                //ObjDb.OpenConnection();
                //ObjDb.CloseConnection();
            }
        }
    }
}
