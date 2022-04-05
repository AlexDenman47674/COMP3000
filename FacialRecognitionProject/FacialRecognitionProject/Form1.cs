using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using MySqlConnector;
using System.Web.Mvc;
using System.Collections.Generic;

namespace FacialRecognitionProject
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        List<String> AllUsernames = new List<String>();
        List<String> AllPasswords = new List<String>();

        private void Form1_Load(object sender, EventArgs e)
        {
            AllUsernames.Add("TestUser1");
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

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            HomeForm MainForm = new HomeForm();

            MainForm.Show();

            this.Hide();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm SignForm = new SignUpForm();

            SignForm.Show();

            this.Hide();
        }
    }
}
