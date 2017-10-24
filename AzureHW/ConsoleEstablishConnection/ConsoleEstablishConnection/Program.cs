using ClassLibrary;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConsoleEstablishConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "annstestserver.database.windows.net";
                builder.UserID = "serveradministrator";
                builder.Password = "qwerty123!";
                builder.InitialCatalog = "AnnsFirstDB";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("************Connection via code from console*****************");  

                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * FROM Table2 ");
                    String sql = sb.ToString();

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("{0} {1} {2}", reader.GetInt32(0), reader.GetInt32(1), reader.GetDateTime(2));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            GetData();
            Console.ReadLine();
        }

        public static void GetData()
        {
            var databaseModel = new Model1();

            var entities = databaseModel.Table1.Take(20).ToList();
            Console.WriteLine("************Connection via entity framework*****************");
            entities.ForEach(i => Console.Write("{0} {1} {2}\t", i.Id, i.AnotherData, i.SomeUsefullData));
        }
    }
}
