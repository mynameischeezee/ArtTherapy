﻿using ArtTherapy.Presentation.UsrCtrl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtTherapy
{
    public partial class MainForm : Form
    {
        public static int CurrentQuestion = 0;
        public static int CurrentPart = 1;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseIMG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }
    }
}
