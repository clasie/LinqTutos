using System;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connetionString;
            SqlConnection cnn;
            connetionString =
                @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
            cnn = new SqlConnection(connetionString);
            cnn.Open();
            Console.Write("Connection Open  !");
            cnn.Close();
            Console.Read();
        }
    }
}


