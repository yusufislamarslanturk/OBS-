using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    class Class1
    {
        static public string notut { get; set; }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-ELT3SDS;Initial Catalog=ogrenci;Integrated Security=True");
        SqlCommand komut;
        SqlDataReader read;
        ogrAnasayfa aç = new ogrAnasayfa();
        ogretmenAnasayfa ac = new ogretmenAnasayfa();

        public void kullanıcı(TextBox kullanıcıadı, TextBox şifre,int sayi)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select *from ogrenci where no='" + kullanıcıadı.Text + "'";

            read = komut.ExecuteReader();
            if(sayi == 1)
            {
                if (read.Read() == true)
                {
                    if (şifre.Text == read["sifre"].ToString())
                    {
                        notut = kullanıcıadı.Text;
                        MessageBox.Show("Giriş Başarılı...");
                        aç.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı.");
                    }

                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.");
                }
                baglanti.Close();
            }
            else
            {
                if (read.Read() == true)
                {
                    if (şifre.Text == read["sifre"].ToString())
                    {
                        MessageBox.Show("Giriş Başarılı...");
                        ac.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Şifre Hatalı.");
                    }

                }
                else
                {
                    MessageBox.Show("Bilgilerinizi kontrol ediniz.");
                }
                baglanti.Close();
            }
            
            
        }
    }
}
