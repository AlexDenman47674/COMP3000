﻿using System;
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
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            HomeForm MainForm = new HomeForm();

            MainForm.Show();

            this.Close();
        }
    }
}