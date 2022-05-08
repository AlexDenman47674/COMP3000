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

        List<User> DBUsers;

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
            if (textBoxInputUsername != null && textBoxInputPassword != null)
            {
                DBUsers.Add(new User() {UserID = DBUsers.Count+1, Username = textBoxInputUsername.Text, Password = textBoxInputPassword.Text, AccountType = 2 });
                string json = JsonConvert.SerializeObject(DBUsers.ToArray());

                System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json", json);

                HomeForm MainForm = new HomeForm();

                MainForm.Show();

                this.Close();
            }

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json"))
            {
                string json = r.ReadToEnd();
                DBUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }
        }
    }
}
