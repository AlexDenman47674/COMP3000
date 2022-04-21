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

        }

        private void databaseViewer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSwitchTable_Click(object sender, EventArgs e)
        {
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
            if (databaseViewer.DataSource == DBImages)
            {
                DBImages.Add(new Images() {ImageID = DBImages.Count+1 , ImageName = textBoxImageName.Text, ImageFile = textBoxImageFile.Text, PersonID = Convert.ToInt32(textBoxPersonID.Text)});
            }
            else
            {
                DBPeople.Add(new Person() {PersonID = DBPeople.Count+1 , Name = textBoxPeopleName.Text, Description = textBoxDescription.Text, UserID = Convert.ToInt32(textBoxUserID.Text)});
            }

            string json = JsonConvert.SerializeObject(DBPeople.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabasePeople.json", json);

            json = JsonConvert.SerializeObject(DBImages.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseImages.json", json);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string RemovedItem;
            Images RemovedObject = new Images();
            Person RemovedPerson = new Person();
            int temp = 0;

            if (databaseViewer.DataSource == DBImages)
            {
                RemovedItem = textBoxImageName.Text;
                foreach (Images i in DBImages)
                {
                    temp += 1;
                    if (i.ImageName == RemovedItem)
                    {
                        RemovedObject = i;
                    }
                }

                DBImages.Remove(RemovedObject);
            }
            else
            {
                RemovedItem = textBoxPeopleName.Text;
                foreach (Person i in DBPeople)
                {
                    temp += 1;
                    if (i.Name == RemovedItem)
                    {
                        RemovedPerson = i;
                    }
                }

                DBPeople.Remove(RemovedPerson);
            }

            string json = JsonConvert.SerializeObject(DBPeople.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabasePeople.json", json);

            json = JsonConvert.SerializeObject(DBImages.ToArray());

            System.IO.File.WriteAllText(@"C:/Users/Alex/Desktop/COMP3000/DatabaseImages.json", json);
        }

        private void buttonAmmend_Click(object sender, EventArgs e)
        {
        }
    }
}
