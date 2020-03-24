using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace Lab2
{
    public class DB
    {
        public void Select(IDbConnection connection)
        {

            {
                var regions = connection.Query<Region>("SELECT * FROM Region");
                foreach (var item in regions)
                {
                    Console.WriteLine($"{item.RegionID} : {item.RegionDescription}");
                }
            }
        }
        public void Insert(IDbConnection connection, int id, string description)
        {
            connection.Execute("INSERT INTO Region(RegionID, RegionDescription) " +
                "VALUES(@id, @desc)",
                new { id = id, desc = description });

        }

        public void Delete(IDbConnection connection, int id, string description)
        {
            connection.Execute("DELETE FROM Region WHERE RegionID=@id", new { id = id, });

        }

        public void Update(IDbConnection connection, int id, string description)
        {
            connection.Execute("INSERT INTO Region(RegionID, RegionDescription) " +
                "VALUES(@id, @desc)",
                new { id = id, desc = description });

        }



    }
}
