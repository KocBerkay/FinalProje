using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Projem
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        Form2 form2 = new Form2();
             
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        string[] isim = new string[] { "Ali", "Ahmet", "Can", "Cemre", "Deniz" };
        string[] soyisim = new string[] { "Yılmaz", "Kaya", "Yıldız", "Hatipoğlu", "Yaprak" };
        int[] hesapNo = new int[] {50,51,52,53,54 };
        string[] Sifre = new string[] {"sifre50", "sifre51", "sifre52", "sifre53", "sifre54", };

        void MusteriGetir()
          {   
            baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog=BANKA-Gorsel Prog;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Musteriler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
          }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            if (txt_Ad.Text == "Berkay" & txt_Soyad.Text == "Koç" & txt_HesapNo.Text == "1" & txt_Sifre.Text == "sifre1")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Hüseyin" & txt_Soyad.Text == "Koç" & txt_HesapNo.Text == "2" & txt_Sifre.Text == "sifre2")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Ülkü" & txt_Soyad.Text == "Koç" & txt_HesapNo.Text == "3" & txt_Sifre.Text == "sifre3")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Simay" & txt_Soyad.Text == "Koç" & txt_HesapNo.Text == "4" & txt_Sifre.Text == "sifre4")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }

            if (txt_Ad.Text == "Emin" & txt_Soyad.Text == "Çağlar" & txt_HesapNo.Text == "5" & txt_Sifre.Text == "sifre5")
            {
                MessageBox.Show("Giriş Yaptınız!");
                form2.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Birşeyleri Yanlış Girdiniz!");

        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {      
            string sorgu = "Insert into Musteriler(Ad,Soyad,Hesap_No,Sifre) values(@ad,@soyad,@hesapno,@sifre)";
            komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@ad",txt_Ad.Text);
            komut.Parameters.AddWithValue("@soyad", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@hesapno", txt_HesapNo.Text);
            komut.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir(); 
        }               

        private void btn_MusteriGoruntule_Click(object sender, EventArgs e)
        {
            MusteriGetir();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_MusteriUret_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            for (int i = 0; i < 50; i++)
            {

                string ad, soyad,hesapno,sifre;
                ad = isim[rastgele.Next(0, isim.Length)];
                soyad = soyisim[rastgele.Next(0, soyisim.Length)];
                hesapno = hesapNo[rastgele.Next(0,hesapNo.Length)].ToString();
                sifre = Sifre[rastgele.Next(0,Sifre.Length)];

                SqlCommand olustur = new SqlCommand("Insert Into Musteriler (Ad,Soyad,Hesap_No,Sifre) values (@ad,@soyad,@hesapno,@sifre)", baglanti); 
                olustur.Parameters.AddWithValue("@ad", ad); 
                olustur.Parameters.AddWithValue("@soyad", soyad); 
                olustur.Parameters.AddWithValue("@hesapno", hesapno); 
                olustur.Parameters.AddWithValue("@sifre", sifre); 
                
                olustur.ExecuteNonQuery();

            }
            baglanti.Close();
        }

        private void btn_KullaniciSil_Click_1(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM Musteriler where Hesap_No=@mno";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@mno", Convert.ToInt32(txt_HesapNo.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }

        private void btn_SifreGuncelle_Click_1(object sender, EventArgs e)
        {
            string sorgu = "Update Musteriler set Ad=@ad,Soyad=@soyad,Hesap_No=@mno,Sifre=@sifre where Hesap_No=@mno";
            komut = new SqlCommand(sorgu, baglanti);

            komut.Parameters.AddWithValue("@ad", txt_Ad.Text);
            komut.Parameters.AddWithValue("@soyad", txt_Soyad.Text);
            komut.Parameters.AddWithValue("@mno", txt_HesapNo.Text);
            komut.Parameters.AddWithValue("@sifre", txt_Sifre.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MusteriGetir();
        }
    }
}
