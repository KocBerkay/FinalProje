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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;      
        SqlDataAdapter da;
        Form3 form3 = new Form3();
        Form4 form4 = new Form4();
        Form5 form5 = new Form5();

        public Form2()
        {
            InitializeComponent();
        }

        public void İslemGetir()
        {
            baglanti = new SqlConnection("Server=.\\SQLEXPRESS;Initial Catalog=BANKA-Gorsel Prog;Integrated Security=true");
            baglanti.Open();
            da = new SqlDataAdapter("Select * from İslemler", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView2.DataSource = tablo;
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_Yatirimlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Yatirimlar.SelectedIndex == 0)
                form3.Show();
                this.Hide();

            if (comboBox_Yatirimlar.SelectedIndex == 1)
                form5.Show();
                this.Hide();
        }

        private void comboBox_Odemeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Odemeler.SelectedIndex == 1)
                form4.Show();
                this.Hide();
        }

        private void btn_GecmisIslemler_Click(object sender, EventArgs e)
        {
            İslemGetir();
        }
    }
}
