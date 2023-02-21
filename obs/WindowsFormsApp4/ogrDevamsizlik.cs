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
    public partial class ogrDevamsizlik : Form
    {
        public ogrDevamsizlik()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");
        DataSet daset = new DataSet();

        private void ogrDevamsizlik_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select dersadi,devamsizlik from notlar where no='" + Class1.notut + "'", baglanti);
            adptr.Fill(daset, "notlar");
            dataGridView1.DataSource = daset.Tables["notlar"];
            baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select devamsizlik from notlar where no='" + Class1.notut + "'", baglanti);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
