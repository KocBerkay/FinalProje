using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projem
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btn_DovizSat_Click(object sender, EventArgs e)
        {
            double AlinanZamanBakiye, AlinanZamanDovizKuru,AlinanZamanDoviz, Bakiye, DovizKuru, SatilacakDoviz,kar,zarar;

            AlinanZamanBakiye = Convert.ToDouble(txt_AlinanZamankiBakiye.Text);
            AlinanZamanDovizKuru = Convert.ToDouble(txt_AlinanZamankiDovizKuru.Text);
            AlinanZamanDoviz = Convert.ToDouble(txt_AlinanZamanDoviz.Text);
            Bakiye = Convert.ToDouble(txt_Bakiye.Text);
            DovizKuru = Convert.ToDouble(txt_DovizKuru.Text);
            SatilacakDoviz = Convert.ToDouble(txt_SatilanDoviz.Text);

            kar = (SatilacakDoviz*DovizKuru-Bakiye)-(AlinanZamanDoviz * AlinanZamanDovizKuru-AlinanZamanBakiye);
            zarar = (SatilacakDoviz * DovizKuru - Bakiye) - (AlinanZamanDoviz * AlinanZamanDovizKuru - AlinanZamanBakiye);

            if ((SatilacakDoviz * DovizKuru - Bakiye) - (AlinanZamanDoviz * AlinanZamanDovizKuru - AlinanZamanBakiye) > 0)
            {
                MessageBox.Show("Döviz Satımı Başarılı!");
                MessageBox.Show("Kar: " + kar);
            }
            else if ((SatilacakDoviz * DovizKuru - Bakiye) - (AlinanZamanDoviz * AlinanZamanDovizKuru - AlinanZamanBakiye) < 0)
            {
                MessageBox.Show("Döviz Satımı Başarılı!");
                MessageBox.Show("Zarar: " + zarar);         
            }

        }

        private void btn_OncekiSayfa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }
    }
}
