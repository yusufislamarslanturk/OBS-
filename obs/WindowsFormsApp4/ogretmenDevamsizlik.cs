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
using System.Net.Mail;
namespace WindowsFormsApp4
{

    public partial class ogretmenDevamsizlik : Form
    {
        public string sms;
        public string mail;
        public string mailizin;

        public ogretmenDevamsizlik()
        {
            InitializeComponent();
        }

       


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");

        DataSet daset = new DataSet();
        private void ogretmenDevamsizlik_Load(object sender, EventArgs e)
        {
           yukle();
        }
        private void yukle()
        {
            baglanti.Open();
            SqlDataAdapter adptr = new SqlDataAdapter("select no,dersadi,devamsizlik from notlar ", baglanti);
            adptr.Fill(daset, "notlar");
            dataGridView1.DataSource = daset.Tables["notlar"];
            baglanti.Close();

        }
        private void guncelle()
        {

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("update notlar set devamsizlik=@devamsizlik where no ='" + txtNo.Text + "'and dersadi ='" + txtDers.Text + "' ", baglanti);
            komut2.Parameters.AddWithValue("@devamsizlik", txtDev.Text);
            komut2.ExecuteNonQuery();


            SqlCommand komut8 = new SqlCommand("select smsizin from ogrenci where no ='" + txtNo.Text + "'", baglanti);
            sms = Convert.ToString(komut8.ExecuteScalar());
            komut8.ExecuteNonQuery();
            

            SqlCommand komut61 = new SqlCommand("select mailizin from ogrenci where no ='" + txtNo.Text + "'", baglanti);
            mailizin = Convert.ToString(komut61.ExecuteScalar());
            komut61.ExecuteNonQuery();

            SqlCommand komut5 = new SqlCommand("select Mail from ogrenci where no ='" + txtNo.Text + "'", baglanti);
            mail = Convert.ToString(komut5.ExecuteScalar());


            komut5.ExecuteNonQuery();

            baglanti.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDev.Text = dataGridView1.CurrentRow.Cells["devamsizlik"].Value.ToString();
            txtDers.Text = dataGridView1.CurrentRow.Cells["dersadi"].Value.ToString();
            txtNo.Text = dataGridView1.CurrentRow.Cells["no"].Value.ToString();
            
      
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            guncelle();
            yukle();
            if (Convert.ToInt32(txtDev.Text) >= 4 && sms == "True")
            {
                MessageBox.Show("Test");
                baglanti.Open();
                SqlCommand komut6 = new SqlCommand("insert into kalan(no,dersAdi,durum) values(@no,@dersAdi,@durum)", baglanti);
                komut6.Parameters.AddWithValue("@no",txtNo);
                komut6.Parameters.AddWithValue("@dersAdi",txtDers);
                komut6.Parameters.AddWithValue("@durum","Kaldı");

                baglanti.Close();
            }
            if(Convert.ToInt32(txtDev.Text) >= 4 && mailizin == "True")
            {
                MessageBox.Show("gonderildi");
                MailMessage email = new MailMessage();
                email.From = new MailAddress("ars-grup.engineering@yandex.com");
                email.To.Add(mail);
                email.Subject = ("doğrulama maili");
                email.Body =txtNo.Text+" numaralı ogrenci dersten kalmistir.";
                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("ars-grup.engineering@yandex.com", "sgcxauojunnpjhrs");

                smtp.Port = 587;
                smtp.Host = "smtp.yandex.com";
                smtp.EnableSsl= true;

                smtp.Send(email);
             
            }
           


        }
    }
}
