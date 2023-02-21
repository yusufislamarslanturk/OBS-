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
    public partial class ogrErasmus : Form
    {
        public ogrErasmus()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");
        private void ogrErasmus_Load(object sender, EventArgs e)
        {

        }

        private void ogrErasmus_Load_1(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand command = new SqlCommand("select avg(ortalama) from notlar where no='" + Class1.notut + "'", baglanti);
            
            double ortalama = Convert.ToDouble(command.ExecuteScalar()) / 25;
            label2.Text = Convert.ToString(ortalama);
            if (ortalama > 2.5) {
                label3.Text = "Erasmus Başvurusu Yapılabilir.";
            } 
            else
                label3.Text = "Erasmus Başvurusu Yapılamaz.";
            baglanti.Close();
        }
    }
}
