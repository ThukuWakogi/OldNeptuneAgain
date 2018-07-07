using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MySql.Data.MySqlClient;
using Neptune.Pages;
using Windows.UI.ViewManagement;
using Windows.ApplicationModel.Core;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Neptune
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static string conn;
        private static MySqlConnection connect;

        public MainPage()
        {
            this.InitializeComponent();
            CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;
        }

        public async void OpenConnection()
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

        public void CloseConnection() => connect.Close();

        //private async void ShowMessageDialogAsync(string message) { new MessageDialog(message).ShowAsync(); }

        private async void AuthenticateWorkerButtonClick(object sender, RoutedEventArgs e)
        {
            if (Authenticated(Convert.ToInt32(workerIdTextBox.Text), workerPasswordTextBox.Text))
            {
                await new MessageDialog("You Good!").ShowAsync();
                Frame.Navigate(typeof(ControlPage));
            }
            else
            {
                await new MessageDialog("You Not!").ShowAsync();
            }
        }

        private bool Authenticated(int id, string password)
        {
            bool authenticate = false;

            using (MySqlCommand cmd = new MySqlCommand())
            {
                OpenConnection();
                cmd.CommandText = "SELECT id, password, salt FROM neptune.credentials WHERE id = @id;";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Connection = connect;
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    if ( Security.HashSHA1(password + reader["salt"].ToString()) == reader["password"].ToString())
                    {
                        authenticate = true;
                    }
                }
                CloseConnection();
            }

            return authenticate;
        }
    }
}
