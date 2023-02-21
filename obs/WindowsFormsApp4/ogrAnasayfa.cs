using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ogrAnasayfa : Form
    {
        public string durum;
        public ogrAnasayfa()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            ogrNot ac = new ogrNot();
            ac.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ogrDevamsizlik ac = new ogrDevamsizlik();
            ac.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            ogrErasmus ac = new ogrErasmus();
            ac.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ogrİletisim ac = new ogrİletisim();
            ac.ShowDialog();
        }

        private void ogrAnasayfa_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand command = new SqlCommand("select dersAdi from kalan where no ='" + Class1.notut + "'", baglanti);
            String dersadi = Convert.ToString(command.ExecuteScalar());
            command.ExecuteNonQuery();

            SqlCommand command1 = new SqlCommand("select durum from kalan where no ='" + Class1.notut + "'", baglanti);
            string durum = Convert.ToString(command1.ExecuteScalar());
            command1.ExecuteNonQuery();


            if (durum == "Kaldı")
            {
                MessageBox.Show(dersadi + " dersinden devamsızlıktan kaldınız.");
            }
            baglanti.Close();
        }
    }
}
