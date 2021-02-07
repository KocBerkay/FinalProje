
namespace Projem
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txt_Bakiye = new System.Windows.Forms.TextBox();
            this.txt_AlinanDoviz = new System.Windows.Forms.TextBox();
            this.txt_DovizKuru = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DovizAl = new System.Windows.Forms.Button();
            this.btn_OncekiSayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Bakiye
            // 
            this.txt_Bakiye.Location = new System.Drawing.Point(361, 98);
            this.txt_Bakiye.Name = "txt_Bakiye";
            this.txt_Bakiye.Size = new System.Drawing.Size(167, 22);
            this.txt_Bakiye.TabIndex = 0;
            // 
            // txt_AlinanDoviz
            // 
            this.txt_AlinanDoviz.Location = new System.Drawing.Point(361, 200);
            this.txt_AlinanDoviz.Name = "txt_AlinanDoviz";
            this.txt_AlinanDoviz.Size = new System.Drawing.Size(167, 22);
            this.txt_AlinanDoviz.TabIndex = 1;
            // 
            // txt_DovizKuru
            // 
            this.txt_DovizKuru.Location = new System.Drawing.Point(361, 148);
            this.txt_DovizKuru.Name = "txt_DovizKuru";
            this.txt_DovizKuru.Size = new System.Drawing.Size(167, 22);
            this.txt_DovizKuru.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bakiyeniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Döviz Kuru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alacağınız Döviz($):";
            // 
            // btn_DovizAl
            // 
            this.btn_DovizAl.Location = new System.Drawing.Point(361, 259);
            this.btn_DovizAl.Name = "btn_DovizAl";
            this.btn_DovizAl.Size = new System.Drawing.Size(75, 50);
            this.btn_DovizAl.TabIndex = 6;
            this.btn_DovizAl.Text = "Döviz Al";
            this.btn_DovizAl.UseVisualStyleBackColor = true;
            this.btn_DovizAl.Click += new System.EventHandler(this.btn_DovizAl_Click);
            // 
            // btn_OncekiSayfa
            // 
            this.btn_OncekiSayfa.Location = new System.Drawing.Point(453, 259);
            this.btn_OncekiSayfa.Name = "btn_OncekiSayfa";
            this.btn_OncekiSayfa.Size = new System.Drawing.Size(75, 50);
            this.btn_OncekiSayfa.TabIndex = 7;
            this.btn_OncekiSayfa.Text = "Önceki Sayfa";
            this.btn_OncekiSayfa.UseVisualStyleBackColor = true;
            this.btn_OncekiSayfa.Click += new System.EventHandler(this.btn_OncekiSayfa_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_OncekiSayfa);
            this.Controls.Add(this.btn_DovizAl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_DovizKuru);
            this.Controls.Add(this.txt_AlinanDoviz);
            this.Controls.Add(this.txt_Bakiye);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Döviz Alış ";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Bakiye;
        private System.Windows.Forms.TextBox txt_AlinanDoviz;
        private System.Windows.Forms.TextBox txt_DovizKuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_DovizAl;
        private System.Windows.Forms.Button btn_OncekiSayfa;
    }
}