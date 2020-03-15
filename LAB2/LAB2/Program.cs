using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")) 
            {
                var db = new DB();
                db.Select(connection);
                db.Insert(connection, 204, "eldo");
                db.Delete(connection, 204, "eldo");
                db.Update(connection, 204, "Hi");
                
            }
            Console.ReadKey();
            
       
        }
    }
}
