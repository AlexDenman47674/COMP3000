using System;
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
    public partial class UserSettingsForm : Form
    {
        HomeForm MainForm = new HomeForm();
        public UserSettingsForm()
        {
            InitializeComponent();
        }
        string InputURL;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();

            LoginForm.Show();
            HomeForm MainForm = new HomeForm();

            MainForm.Close();
            this.Close();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            PasswordForm PassForm = new PasswordForm();

            PassForm.Show();
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            InputURL = textBoxInputWebsite.Text;

            MainForm.MyURL = InputURL;
            MainForm.Show();
            this.Close();
        }
    }
}
