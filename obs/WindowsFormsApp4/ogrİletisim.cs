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
    public partial class ogrİletisim : Form
    {
        public string mailtik;
        public ogrİletisim()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");
        private void ogrİletisim_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
           
            

            if (checkBox1.Checked)
            {
                SqlCommand komut = new SqlCommand("update ogrenci set smsizin=@smsizin where no ='" + Class1.notut + "'", baglanti);
                komut.Parameters.AddWithValue("@smsizin", "True");
                komut.ExecuteNonQuery();

            }
            else
            {
                SqlCommand komut = new SqlCommand("update ogrenci set smsizin=@smsizin where no ='" + Class1.notut + "'", baglanti);

             
                komut.Parameters.AddWithValue("@smsizin", "False");
                komut.ExecuteNonQuery();

            }

            if (checkBox3.Checked)
            {
                SqlCommand komut2 = new SqlCommand("update ogrenci set mailizin=@mailizin where no ='" + Class1.notut + "'", baglanti);
                komut2.Parameters.AddWithValue("@mailizin", "True");
                komut2.ExecuteNonQuery();
            }
            else
            {
                SqlCommand komut2 = new SqlCommand("update ogrenci set mailizin=@mailizin where no ='" + Class1.notut + "'", baglanti);
                komut2.Parameters.AddWithValue("@mailizin", "False");
                komut2.ExecuteNonQuery();


            }
            MessageBox.Show("Güncellendi.");

            baglanti.Close();
           
           
        }
    }
}
