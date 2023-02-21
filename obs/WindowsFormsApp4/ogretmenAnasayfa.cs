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
    public partial class ogretmenAnasayfa : Form
    {
        public ogretmenAnasayfa()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ogretErasmus ac = new ogretErasmus();
            ac.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ogretmenNot ac = new ogretmenNot();
            ac.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ogretmenDevamsizlik ac = new ogretmenDevamsizlik();
            ac.ShowDialog();
        }

        private void ogretmenAnasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
