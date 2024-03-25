using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Rest0._1
{
    internal class DataBase
    {

        SqlConnection SQLconnection = new SqlConnection(@"Data Source=MORPEX;Initial Catalog=MainRestDB;Integrated Security=true");

        public void OpenConnection()
        {
            if (SQLconnection.State == System.Data.ConnectionState.Closed)
            {
                SQLconnection.Open();
            }
        }

        public void CloseConnection()
        {
            if (SQLconnection.State == System.Data.ConnectionState.Open)
            {
                SQLconnection.Close();
            }
        }

        public SqlConnection GetConnection()
        {
            return SQLconnection;
        }

        public void CreateOrder(int TableNum, string OrderStatus, string Dish1, int Pos1, string Dish2, int Pos2, string Dish3, int Pos3, int TotalPrice, string Comments)
        {
            string query = "INSERT INTO Orders (TableNum, OrderStatus, Dish1, Pos1, Dish2, Pos2, Dish3, Pos3, TotalPrice, Comments) VALUES (@TableNum, @OrderStatus, @Dish1, @Pos1, @Dish2, @Pos2, @Dish3, @Pos3, @TotalPrice, @Comments)";
            SqlCommand command = new SqlCommand(query, SQLconnection);
            command.Parameters.AddWithValue("@TableNum", TableNum);
            command.Parameters.AddWithValue("@OrderStatus", OrderStatus);
            command.Parameters.AddWithValue("@Dish1", Dish1);
            command.Parameters.AddWithValue("@Pos1", Pos1);
            command.Parameters.AddWithValue("@Dish2", Dish2);
            command.Parameters.AddWithValue("@Pos2", Pos2);
            command.Parameters.AddWithValue("@Dish3", Dish3);
            command.Parameters.AddWithValue("@Pos3", Pos3);
            command.Parameters.AddWithValue("@TotalPrice", TotalPrice);
            command.Parameters.AddWithValue("@Comments", Comments);
            OpenConnection();
            command.ExecuteNonQuery();
            CloseConnection();
        }

        public bool IsOrderCreated(string orderStatus)
        {
            string query = "SELECT * FROM Orders WHERE OrderStatus = @OrderStatus";
            SqlCommand command = new SqlCommand(query, SQLconnection);
            command.Parameters.AddWithValue("@OrderStatus", orderStatus);
            OpenConnection();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                CloseConnection();
                return true;
            }
            else
            {
                CloseConnection();
                return false;
            }
        }
    }
}
