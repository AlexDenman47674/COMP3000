using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    public partial class PasswordForm : Form
    {
        HomeForm MainForm = new HomeForm();
        public PasswordForm()
        {
            InitializeComponent();
        }

        List<User> DBUsers;
        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int AccountType { get; set; }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPrevPassword.Text != null && textBoxNewPassword.Text != null && textBoxConfirmPassword.Text != null)
            {
                for (int i = 0; i <= DBUsers.Count-1; i++)
                {
                    if (textBoxPrevPassword.Text == DBUsers[MainForm.MyUser].Password && textBoxNewPassword.Text == textBoxConfirmPassword.Text)
                    {
                        DBUsers[MainForm.MyUser].Password = textBoxNewPassword.Text;
                        string json = JsonConvert.SerializeObject(DBUsers.ToArray());

                        System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json", json);

                        MainForm.Show();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not match, please try again");
                    }
                }


            }

        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json"))
            {
                string json = r.ReadToEnd();
                DBUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}
