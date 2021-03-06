using System;
using System.Data.SqlClient;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Intagrated Security=True;Connect Timeout=60;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            using var connection = new SqlConnection(connectionString);
            connection.Open();
            var zapytanie = "Select * From Customer";

            var command = new SqlCommand(zapytanie, connection);

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(1));
            }
            connection.Close();
        }
    }
}
