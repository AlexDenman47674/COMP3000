using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacialRecognitionProject
{
    public partial class CameraForm : Form
    {

        AzureFace FaceAI = new AzureFace();

        public CameraForm()
        {
            InitializeComponent();

        }

        private void CameraForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FaceAI.AzureMain();
        }
    }
}
