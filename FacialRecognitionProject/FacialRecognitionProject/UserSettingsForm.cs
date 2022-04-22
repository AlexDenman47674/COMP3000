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

        List<Person> DBPeople;
        List<Images> DBImages;

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

            string json2 = JsonConvert.SerializeObject(DBPeople.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabasePeopleBackup.json", json2);

            json2 = JsonConvert.SerializeObject(DBImages.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseImagesBackup.json", json2);
        }
    }
}
