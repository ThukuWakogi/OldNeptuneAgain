using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Windows.UI.Popups;

namespace Neptune
{
    public static class Database
    {
        private static string conn;
        private static MySqlConnection connect;
        private static MySqlCommand cmd;
        public static MySqlDataReader reader;

        public static async void OpenConnection()
        {

            try
            {
                conn = "Server=localhost;Database=neptune;Uid=client;Pwd=client;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (MySqlException e)
            {
                await new MessageDialog(e.Message).ShowAsync();
            }
        }

        public static void CloseConnection()
        {
            connect.Close();
        }

        public static MySqlCommand Cmd => cmd = new MySqlCommand();
        public static MySqlDataReader Results(MySqlCommand cmd) => cmd.ExecuteReader();
    }
}
