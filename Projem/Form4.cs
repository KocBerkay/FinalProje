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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btn_Ode_Click(object sender, EventArgs e)
        {
            double faturatutari, taksit,odenecektutar;
            faturatutari = Convert.ToDouble(txt_OdenecekTutar.Text);
            taksit = Convert.ToDouble(txt_Taksit.Text);

            if (txt_Taksit.Text == "")
                odenecektutar = faturatutari;
            else
                odenecektutar = faturatutari / taksit;
            MessageBox.Show("Bu Ay Odenecek Tutar ",odenecektutar.ToString());
        }

        private void btn_OncekiSayfayaDon_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }

        private void cmb_Fatura_SelectedIndexChanged(object sender, EventArgs e)
        {          
            if (cmb_Fatura.SelectedIndex == 0)         
                MessageBox.Show("Vergi Miktarı--> %21");   
            if(cmb_Fatura.SelectedIndex == 1)
                MessageBox.Show("Vergi Oranı--> %44");
            if(cmb_Fatura.SelectedIndex == 2)
                MessageBox.Show("Vergi Oranı--> %17,3");
            if(cmb_Fatura.SelectedIndex == 3)
                MessageBox.Show("Vergi Oranı--> %28");
        }
    }
}
