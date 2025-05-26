using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace E_commerce.Data_Access_Layer
{
    class DAL
    {
        MySqlConnection mySqlConnection;
        public DAL()
        {
            string mysqlCon = "server=localhost; user=root; database=e-commerce; password=";
            mySqlConnection = new MySqlConnection(mysqlCon);
        }
        public void open()
        {

            try
            {
                mySqlConnection.Open();
                Console.WriteLine("connection succress");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void close()
        {
            mySqlConnection.Close();
        }

        public MySqlDataReader selectFromDtatbase(string sql)
        {
            MySqlCommand command=new MySqlCommand(sql, mySqlConnection);
            Console.WriteLine(sql);
            MySqlDataReader dataReader=command.ExecuteReader();
            return dataReader;
        }

        public void insertToDatabase(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, mySqlConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.InsertCommand=new MySqlCommand(sql, mySqlConnection);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
        }

    }
}
