using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ogrGiris ac = new ogrGiris();
            ac.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ogretmenGiris ac = new ogretmenGiris();
            ac.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
