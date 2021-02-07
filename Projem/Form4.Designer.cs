
namespace Projem
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.btn_OncekiSayfayaDon = new System.Windows.Forms.Button();
            this.cmb_Fatura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OdenecekTutar = new System.Windows.Forms.TextBox();
            this.txt_Taksit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OncekiSayfayaDon
            // 
            this.btn_OncekiSayfayaDon.Location = new System.Drawing.Point(359, 349);
            this.btn_OncekiSayfayaDon.Name = "btn_OncekiSayfayaDon";
            this.btn_OncekiSayfayaDon.Size = new System.Drawing.Size(100, 66);
            this.btn_OncekiSayfayaDon.TabIndex = 0;
            this.btn_OncekiSayfayaDon.Text = "Önceki Sayfaya Dön";
            this.btn_OncekiSayfayaDon.UseVisualStyleBackColor = true;
            this.btn_OncekiSayfayaDon.Click += new System.EventHandler(this.btn_OncekiSayfayaDon_Click);
            // 
            // cmb_Fatura
            // 
            this.cmb_Fatura.FormattingEnabled = true;
            this.cmb_Fatura.Items.AddRange(new object[] {
            "Elektrik",
            "Su",
            "Doğalgaz",
            "İnternet"});
            this.cmb_Fatura.Location = new System.Drawing.Point(269, 61);
            this.cmb_Fatura.Name = "cmb_Fatura";
            this.cmb_Fatura.Size = new System.Drawing.Size(211, 24);
            this.cmb_Fatura.TabIndex = 1;
            this.cmb_Fatura.Text = "Ödeyeceğiniz Faturayı Seçin";
            this.cmb_Fatura.SelectedIndexChanged += new System.EventHandler(this.cmb_Fatura_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ödenecek Tutar:";
            // 
            // txt_OdenecekTutar
            // 
            this.txt_OdenecekTutar.Location = new System.Drawing.Point(359, 176);
            this.txt_OdenecekTutar.Name = "txt_OdenecekTutar";
            this.txt_OdenecekTutar.Size = new System.Drawing.Size(100, 22);
            this.txt_OdenecekTutar.TabIndex = 3;
            // 
            // txt_Taksit
            // 
            this.txt_Taksit.Location = new System.Drawing.Point(359, 228);
            this.txt_Taksit.Name = "txt_Taksit";
            this.txt_Taksit.Size = new System.Drawing.Size(100, 22);
            this.txt_Taksit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Taksit(İsteğe Bağlı);";
            // 
            // btn_Ode
            // 
            this.btn_Ode.Location = new System.Drawing.Point(359, 291);
            this.btn_Ode.Name = "btn_Ode";
            this.btn_Ode.Size = new System.Drawing.Size(100, 23);
            this.btn_Ode.TabIndex = 6;
            this.btn_Ode.Text = "Öde";
            this.btn_Ode.UseVisualStyleBackColor = true;
            this.btn_Ode.Click += new System.EventHandler(this.btn_Ode_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Taksit);
            this.Controls.Add(this.txt_OdenecekTutar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_Fatura);
            this.Controls.Add(this.btn_OncekiSayfayaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fatura Ödeme";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OncekiSayfayaDon;
        private System.Windows.Forms.ComboBox cmb_Fatura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OdenecekTutar;
        private System.Windows.Forms.TextBox txt_Taksit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ode;
    }
}