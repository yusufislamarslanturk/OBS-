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
    public partial class ogretErasmus : Form
    {
        public ogretErasmus()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");
        DataSet daset = new DataSet();

        private void ogretErasmus_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select no,adi,soyadi,erasmusdurumu from ogrenci ", baglanti);
            adptr.Fill(daset, "ogrenci");
            dataGridView1.DataSource = daset.Tables["ogrenci"];
            baglanti.Close();

        }
    }
}
