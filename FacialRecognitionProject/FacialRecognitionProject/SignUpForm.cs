using System;
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
    }
}
