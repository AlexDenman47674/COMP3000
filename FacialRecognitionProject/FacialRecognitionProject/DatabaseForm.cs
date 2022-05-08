using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    public partial class DatabaseForm : Form
    {
        HomeForm MainForm = new HomeForm();
        public DatabaseForm()
        {
            InitializeComponent();
        }

        List<Person> DBPeople;
        List<Images> DBImages;

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

        List<User> DBUsers;

        public class User
        {
            public int UserID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public int AccountType { get; set; }
        }

        private void DatabaseForm_Load(object sender, EventArgs e)
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

            databaseViewer.DataSource = DBImages;

            using (StreamReader r3 = new StreamReader("C:/Users/Alex/Desktop/COMP3000/DatabaseUsers.json"))
            {
                string json = r3.ReadToEnd();
                DBUsers = JsonConvert.DeserializeObject<List<User>>(json);
            }

            labelCurrentUser.Text = DBUsers[MainForm.MyUser].Username;

        }

        private void databaseViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSwitchTable_Click(object sender, EventArgs e)
        {
            //If DBImages is the current source, switch to DBPeople
            if (databaseViewer.DataSource == DBImages)
            {
                databaseViewer.DataSource = DBPeople;

                textBoxPeopleName.Enabled = true;
                textBoxDescription.Enabled = true;
                textBoxUserID.Enabled = true;

                textBoxImageName.Enabled = false;
                textBoxImageFile.Enabled = false;
                textBoxPersonID.Enabled = false;
            }
            else
            {
                //Else switch to DBImages
                databaseViewer.DataSource = DBImages;

                textBoxPeopleName.Enabled = false;
                textBoxDescription.Enabled = false;
                textBoxUserID.Enabled = false;

                textBoxImageName.Enabled = true;
                textBoxImageFile.Enabled = true;
                textBoxPersonID.Enabled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //if the datasource = DBImages update the Images dataset
            if (databaseViewer.DataSource == DBImages)
            {
                DBImages.Add(new Images() {ImageID = DBImages.Count+1 , ImageName = textBoxImageName.Text, ImageFile = textBoxImageFile.Text, PersonID = Convert.ToInt32(textBoxPersonID.Text)});
            }
            //else update the People dataset
            else
            {
                DBPeople.Add(new Person() {PersonID = DBPeople.Count+1 , Name = textBoxPeopleName.Text, Description = textBoxDescription.Text, UserID = Convert.ToInt32(textBoxUserID.Text)});
            }

            string json = JsonConvert.SerializeObject(DBPeople.ToArray());

            //Write to the DatabasePeople & DatabaseImages JSON files
            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabasePeople.json", json);

            json = JsonConvert.SerializeObject(DBImages.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseImages.json", json);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string RemovedItem;
            Images RemovedObject = new Images();
            Person RemovedPerson = new Person();

            if (databaseViewer.DataSource == DBImages)
            {
                RemovedItem = textBoxImageName.Text;
                //Each item in DBImages are compared to RemovedObject
                foreach (Images i in DBImages)
                {
                    if (i.ImageName == RemovedItem)
                    {
                        RemovedObject = i;
                    }
                }
                //Selected item is removed
                DBImages.Remove(RemovedObject);
            }
            else
            {
                RemovedItem = textBoxPeopleName.Text;
                foreach (Person i in DBPeople)
                {
                    //Items in DBPeople also compared
                    if (i.Name == RemovedItem)
                    {
                        RemovedPerson = i;
                    }
                }
                //And removed
                DBPeople.Remove(RemovedPerson);
            }

            string json = JsonConvert.SerializeObject(DBPeople.ToArray());

            //Changes commited to the relevent JSON files
            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabasePeople.json", json);

            json = JsonConvert.SerializeObject(DBImages.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseImages.json", json);
        }

        private void buttonAmmend_Click(object sender, EventArgs e)
        {
        }
    }
}
