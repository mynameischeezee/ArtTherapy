using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtTherapy.Presentation.UsrCtrl
{
    public partial class Result : UserControl
    {
        public Result()
        {
            InitializeComponent();
        }

        private void CloseIMG_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
