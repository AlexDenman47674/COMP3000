using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace FacialRecognitionProject
{
    public partial class HomeForm : Form
    {
        string FavURL;
        int CurrentUser = 0;

        public string MyURL
        {
            get
            {
                return FavURL;
            }
            set
            {
                if (FavURL != value)
                    FavURL = value;
            }
        }

        public int MyUser
        {
            get
            {
                return CurrentUser;
            }
            set
            {
                if (CurrentUser != value)
                    CurrentUser = value;
            }
        }

        //Create DBUsers list
        List<User> DBUsers;

        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int AccountType { get; set; }
        }

        public HomeForm()
        {
            InitializeComponent();
        }


        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            //Fetch the current date/time
            labelCurrentTime.Text = DateTime.Now.ToString("h:mm:ss tt");
            labelCurrentDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        private void buttonDatabase_Click(object sender, EventArgs e)
        {
            DatabaseForm DataForm = new DatabaseForm();

            DataForm.ShowDialog();

        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutForm AboutUsForm = new AboutForm();

            AboutUsForm.ShowDialog();
        }

        private void buttonCamera_Click(object sender, EventArgs e)
        {
            CameraForm CamForm = new CameraForm();

            CamForm.ShowDialog();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            UserSettingsForm SettingsForm = new UserSettingsForm();

            SettingsForm.ShowDialog();
            this.Close();
        }

        private void buttonUpdateWeb_Click(object sender, EventArgs e)
        {
            
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            //Read JSON data into DBUsers
            using (StreamReader r = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json"))
            {
                string json = r.ReadToEnd();
                DBUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }
            //Set Current User
            labelCurrentUser.Text = DBUsers[MyUser].Username;

            //Read in FavURL
            FavURL = System.IO.File.ReadAllText(@"C:/Users/Alex/Desktop/COMP3000/BookmarkedWebsite.txt");
            webBrowser1.Navigate(new Uri(MyURL));
        }
    }
}
