using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001202045_VuNgoDat_SM24_Buoi7
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void menuB1_Click(object sender, EventArgs e)
        {
            new Views.QL_SinhVien().Show();
        }

        private void menuB2_Click(object sender, EventArgs e)
        {
            new Views.QL_Diem().Show();
        }

        private void menuB1_BTVN_Click(object sender, EventArgs e)
        {

        }
    }
}
