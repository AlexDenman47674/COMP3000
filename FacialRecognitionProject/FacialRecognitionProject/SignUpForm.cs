using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int AccountType { get; set; }
        }

        private void timerSignUp_Tick(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked == true)
            {
                textBoxInputPassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxInputPassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            HomeForm MainForm = new HomeForm();

            MainForm.Show();

            this.Close();
        }
    }
}
