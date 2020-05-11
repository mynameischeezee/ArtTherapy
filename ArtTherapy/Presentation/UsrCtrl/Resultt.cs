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
using System.Text.RegularExpressions;

namespace ArtTherapy.Presentation.UsrCtrl
{
    public partial class Resultt : UserControl
    {
        public void SetText()
        {
            Result res = FindResult.ReturnResult();
            lbl_Header.Text = $"За результатом тесту ваш темперамент {res.Temp} і ви перебуваєте у стані {res.Mood}.\r\nІдеальний вид терапії для вас це:";
            pic.Image = res.Img;
            lbl_Direction.Text = res.Type;
            txtbox_Direction.Text = res.Text2;
            txtbox_About.Text = res.About1;
        }
        public Resultt()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {

        }

        private void btn_OpenInBrowser_Click(object sender, EventArgs e)
        {
            Result res = FindResult.ReturnResult();
            System.Diagnostics.Process.Start(res.URL);
        }
    }
}
