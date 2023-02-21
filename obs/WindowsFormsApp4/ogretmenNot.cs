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
    public partial class ogretmenNot : Form
    {
        public ogretmenNot()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Listele()
        {
            DataSet daset = new DataSet();
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select no,dersadi,vize,final,but,ortalama from notlar", baglanti);
            adptr.Fill(daset, "notlar");
            dataGridView1.DataSource = daset.Tables["notlar"];
            baglanti.Close();
        }
        private void Hesapla()
        {
            int but = 0;
            int vize = Convert.ToInt32(txtVize.Text);
            int final = Convert.ToInt32(txtFinal.Text);
            if(txtBut.Text != "")
            {
                but = Convert.ToInt32(txtBut.Text);
            }
            if (final < 50 || (vize*4+final*6)/10 <50)
            {
                label7.Show();
                label7.ForeColor=(Color.White);
                label7.Text = ((vize * 4 + but * 6) / 10).ToString();

            }
            else
            {
                label7.Show();
                label7.ForeColor = (Color.White);
                label7.Text = ((vize * 4 + final * 6) / 10).ToString();

            }
            baglanti.Open();
            SqlCommand command = new SqlCommand("select avg(ortalama) from notlar where no='" + txtNo.Text + "'", baglanti);
            double ortalama = Convert.ToDouble(command.ExecuteScalar()) / 25;
            command.ExecuteNonQuery();
            
            SqlCommand komut2 = new SqlCommand("update ogrenci set genelortalama=@genelortalama where no ='" + txtNo.Text + "'", baglanti);
            komut2.Parameters.AddWithValue("@genelortalama", ortalama);
            komut2.ExecuteNonQuery();

            SqlCommand komut4 = new SqlCommand("update notlar set ortalama=@ortalama where no ='" + txtNo.Text + "'and dersadi ='" + label8.Text + "' ", baglanti);
            komut4.Parameters.AddWithValue("@ortalama", label7.Text);
            komut4.ExecuteNonQuery();
            SqlCommand komut3 = new SqlCommand("update ogrenci set erasmusdurumu=@erasmusdurumu where no = '" + txtNo.Text + "'", baglanti);
            if (ortalama > 2.5)
            { 
                komut3.Parameters.AddWithValue("@erasmusdurumu", "Erasmusa Gidebilir.");
                komut3.ExecuteNonQuery();
            }
            else
            {
                komut3.Parameters.AddWithValue("@erasmusdurumu", "Erasmusa Gidemez.");
                komut3.ExecuteNonQuery();
            }

            baglanti.Close();
        }
        private void kullanıcıtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ogretmenNot_Load(object sender, EventArgs e)
        {
            Listele();
        }

   
       
        
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtVize.Text = dataGridView1.CurrentRow.Cells["vize"].Value.ToString();
            txtFinal.Text = dataGridView1.CurrentRow.Cells["final"].Value.ToString();
            txtBut.Text = dataGridView1.CurrentRow.Cells["but"].Value.ToString();
            txtNo.Text = dataGridView1.CurrentRow.Cells["no"].Value.ToString();
            label8.Text = dataGridView1.CurrentRow.Cells["dersadi"].Value.ToString();
            label8.Show();
            label8.ForeColor = Color.White;
            System.Threading.Thread.Sleep(1000);
            Hesapla();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update notlar set but=@but,final=@final,vize=@vize where no=@no and dersadi=@dersadi", baglanti);
            komut.Parameters.AddWithValue("@no", txtNo.Text);
            komut.Parameters.AddWithValue("@but", txtBut.Text);
            komut.Parameters.AddWithValue("@final", txtFinal.Text);
            komut.Parameters.AddWithValue("@vize", txtVize.Text);
            komut.Parameters.AddWithValue("@dersadi",label8.Text);
            
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme yapıldı.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            Listele();
            label7.Hide();
            label8.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
