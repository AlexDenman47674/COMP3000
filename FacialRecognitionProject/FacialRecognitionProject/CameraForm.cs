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
    public partial class CameraForm : Form
    {
        //Create the FaceAI variable referencing the AzureFace class
        AzureFace FaceAI = new AzureFace();
        //Create the DBPeople & DBImages lists
        List<Person> DBPeople;
        List<Images> DBImages;

        //Create the Person & Images classes
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

        public CameraForm()
        {
            InitializeComponent();

        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //By using threading the AzureFace class can be run without stopping the Camera form
            await Task.Run(() => FaceAI.AzureMain(textBoxInputTarget.Text));
            //Display outputted information to the user
            pictureBoxImage.ImageLocation = $"{FaceAI.CurrentPersonURL}";
            textBoxName.Text = FaceAI.CurrentPersonName;
            textBoxDescription.Text = FaceAI.CurrentPersonDescription;
            textBoxImageName.Text = FaceAI.CurrentPersonImageName;
            textBoxPersonID.Text = FaceAI.CurrentPersonID;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }
    }
}
