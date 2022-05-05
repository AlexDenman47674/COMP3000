//Import system settings into Form
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using MySqlConnector;
using System.Web.Mvc;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace FacialRecognitionProject
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //DBUsers variable designed to store user info from JSON file
        List<User> DBUsers;


        //User class designed to match Users JSON file
        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int AccountType { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //StreamReader takes data from DatabaseUsers.json
            using (StreamReader r = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json"))
            {
                string json = r.ReadToEnd();
                DBUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }

        private void timerPasswordCheck_Tick(object sender, EventArgs e)
        {
            //Every tick if checkbox is checked hidden characters are replaced with plaintext
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
            //Compare input to username and passwords stored in JSON file
            for (int i = 0; i <= DBUsers.Count-1; i++)
            {
                if (textBoxInputName.Text == DBUsers[i].Username && textBoxInputPassword.Text == DBUsers[i].Password)
                {
                    HomeForm MainForm = new HomeForm();

                    MainForm.MyUser = i;
                    //if successful takes user to Main Form
                    MainForm.Show();

                    this.Hide();
                }
            }

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            //Takes user to Sign Up Form
            SignUpForm SignForm = new SignUpForm();

            SignForm.Show();

            this.Hide();
        }
    }
}
