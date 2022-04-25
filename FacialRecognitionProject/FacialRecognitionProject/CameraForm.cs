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

        AzureFace FaceAI = new AzureFace();
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

        public CameraForm()
        {
            InitializeComponent();

        }

        private void CameraForm_Load(object sender, EventArgs e)
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Run(() => FaceAI.AzureMain());
        }
    }
}
