using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using MySqlConnector;
using System.Web.Mvc;

namespace FacialRecognitionProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class HomeController : Controller
        {
            readonly MySqlConnectionStringBuilder _connectionString;

            public HomeController(
                MySqlConnectionStringBuilder connectionString)
            {
                this._connectionString = connectionString;

                try
                {
                    using (var connection = new MySqlConnection(_connectionString.ConnectionString))
                    {
                        connection.Open();
                        MessageBox.Show("Connection Established");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occurred");
                }

            }


        }

            private void Form1_Load(object sender, EventArgs e)
        {
            var connectionString = new MySqlConnectionStringBuilder()
            {
                SslMode = MySqlSslMode.None,

                Server = Environment.GetEnvironmentVariable("34.89.124.128"),   // e.g. '127.0.0.1'
                UserID = Environment.GetEnvironmentVariable("adenman"),   // e.g. 'my-db-user'
                Password = Environment.GetEnvironmentVariable("Treclaren01%"), // e.g. 'my-db-password'
                Database = Environment.GetEnvironmentVariable("COMP3000"), // e.g. 'my-database'
            };
            connectionString.Pooling = true;


        }
    }
}
