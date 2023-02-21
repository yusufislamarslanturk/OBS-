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
    public partial class ogretmenGiris : Form
    {
        public ogretmenGiris()
        {
            InitializeComponent();
        }

        private void ogretmenAnasayfa_Load(object sender, EventArgs e)
        {

        }
        Class1 c = new Class1();
        private void button1_Click(object sender, EventArgs e)
        {
            c.kullanıcı(kullanıcıtxt,sifretxt, 0);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
