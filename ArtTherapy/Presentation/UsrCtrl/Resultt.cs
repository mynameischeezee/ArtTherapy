using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArtTherapy.BussinesLogic;

namespace ArtTherapy.Presentation.UsrCtrl
{
    public partial class Resultt : UserControl
    {
        
        public Resultt()
        {
            InitializeComponent();
        }

        private void CloseIMG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void SetText()
        {
            Result res = FindResult.ReturnResult();
            ResultText.Text = res.Text1;
            Result2Text.Text = res.Text2;
            ResultIMG.Image = res.Img;
            Mood.Text = res.Mood;
            Temperament.Text = res.Temp;
        }

        private void Result_Load(object sender, EventArgs e)
        {

        }

        private void OpenInBrowser_Click(object sender, EventArgs e)
        {
            Result res = FindResult.ReturnResult();
            System.Diagnostics.Process.Start(res.URL);
        }
    }
}
