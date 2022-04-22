using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    public partial class UserSettingsForm : Form
    {
        public class Person
        {
            public int PersonID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int UserID { get; set; }
        }

        public class Images
        {
            public int ImageID { get; set; }
            public string ImageName { get; set; }
            public string ImageFile { get; set; }
            public int PersonID { get; set; }
        }

        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int AccountType { get; set; }
        }

        List<Person> DBPeople;
        List<Images> DBImages;
        List<User> DBUsers;

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

            using (StreamWriter writer = new StreamWriter("C:/Users/Alex/Desktop/COMP3000/BookmarkedWebsite.txt"))
            {
                writer.WriteLine(InputURL);
            }
                MainForm.Show();
            this.Close();
        }

        private void buttonClearData_Click(object sender, EventArgs e)
        {
            using (StreamReader r = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabasePeople.json"))
            {
                string json = r.ReadToEnd();
                DBPeople = JsonConvert.DeserializeObject<List<Person>>(json);
            }

            using (StreamReader r2 = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseImages.json"))
            {
                string json = r2.ReadToEnd();
                DBImages = JsonConvert.DeserializeObject<List<Images>>(json);
            }

            using (StreamReader r3 = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json"))
            {
                string json = r3.ReadToEnd();
                DBUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }


        }
    }
}
