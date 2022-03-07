using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using MySqlConnector;
using System.Web.Mvc;


namespace FacialRecognitionProject
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timerPasswordCheck_Tick(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked==true)
            {
                textBoxInputPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxInputPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
