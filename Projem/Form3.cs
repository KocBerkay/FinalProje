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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btn_DovizAl_Click(object sender, EventArgs e)
        {
            double bakiye, dovizkuru, alinandoviz;
            bakiye = Convert.ToDouble(txt_Bakiye.Text);
            dovizkuru = Convert.ToDouble(txt_DovizKuru.Text);
            alinandoviz = Convert.ToDouble(txt_AlinanDoviz.Text);
            if(alinandoviz*dovizkuru>bakiye)
                MessageBox.Show("Bakiye Yetersiz");
            else
                MessageBox.Show("Döviz Başarıyla Alındı!");
        }

        private void btn_OncekiSayfa_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Close();
            form2.Show();
        }
    }
}
