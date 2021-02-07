
namespace Projem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.txt_HesapNo = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.btn_SifreGuncelle = new System.Windows.Forms.Button();
            this.btn_KullaniciSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_MusteriGoruntule = new System.Windows.Forms.Button();
            this.btn_MusteriUret = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(178, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(178, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(178, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(178, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hesap No:";
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(305, 74);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(168, 22);
            this.txt_Ad.TabIndex = 5;
            // 
            // txt_HesapNo
            // 
            this.txt_HesapNo.Location = new System.Drawing.Point(305, 167);
            this.txt_HesapNo.Name = "txt_HesapNo";
            this.txt_HesapNo.Size = new System.Drawing.Size(168, 22);
            this.txt_HesapNo.TabIndex = 6;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(305, 207);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(168, 22);
            this.txt_Sifre.TabIndex = 7;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(305, 120);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(168, 22);
            this.txt_Soyad.TabIndex = 8;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Giris.Location = new System.Drawing.Point(305, 304);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 34);
            this.btn_Giris.TabIndex = 9;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.Location = new System.Drawing.Point(398, 304);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(75, 34);
            this.btn_KayitOl.TabIndex = 11;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = true;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // btn_SifreGuncelle
            // 
            this.btn_SifreGuncelle.Location = new System.Drawing.Point(398, 362);
            this.btn_SifreGuncelle.Name = "btn_SifreGuncelle";
            this.btn_SifreGuncelle.Size = new System.Drawing.Size(85, 55);
            this.btn_SifreGuncelle.TabIndex = 20;
            this.btn_SifreGuncelle.Text = "Şifre Güncelle";
            this.btn_SifreGuncelle.UseVisualStyleBackColor = true;
            this.btn_SifreGuncelle.Click += new System.EventHandler(this.btn_SifreGuncelle_Click_1);
            // 
            // btn_KullaniciSil
            // 
            this.btn_KullaniciSil.Location = new System.Drawing.Point(305, 362);
            this.btn_KullaniciSil.Name = "btn_KullaniciSil";
            this.btn_KullaniciSil.Size = new System.Drawing.Size(75, 55);
            this.btn_KullaniciSil.TabIndex = 21;
            this.btn_KullaniciSil.Text = "Kullanıcı Sil";
            this.btn_KullaniciSil.UseVisualStyleBackColor = true;
            this.btn_KullaniciSil.Click += new System.EventHandler(this.btn_KullaniciSil_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(650, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(496, 343);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // btn_MusteriGoruntule
            // 
            this.btn_MusteriGoruntule.Location = new System.Drawing.Point(182, 304);
            this.btn_MusteriGoruntule.Name = "btn_MusteriGoruntule";
            this.btn_MusteriGoruntule.Size = new System.Drawing.Size(90, 113);
            this.btn_MusteriGoruntule.TabIndex = 24;
            this.btn_MusteriGoruntule.Text = "Müşterileri Görüntüle";
            this.btn_MusteriGoruntule.UseVisualStyleBackColor = true;
            this.btn_MusteriGoruntule.Click += new System.EventHandler(this.btn_MusteriGoruntule_Click);
            // 
            // btn_MusteriUret
            // 
            this.btn_MusteriUret.Location = new System.Drawing.Point(518, 362);
            this.btn_MusteriUret.Name = "btn_MusteriUret";
            this.btn_MusteriUret.Size = new System.Drawing.Size(90, 58);
            this.btn_MusteriUret.TabIndex = 25;
            this.btn_MusteriUret.Text = "Müşteri Üret";
            this.btn_MusteriUret.UseVisualStyleBackColor = true;
            this.btn_MusteriUret.Click += new System.EventHandler(this.btn_MusteriUret_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 453);
            this.Controls.Add(this.btn_MusteriUret);
            this.Controls.Add(this.btn_MusteriGoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_KullaniciSil);
            this.Controls.Add(this.btn_SifreGuncelle);
            this.Controls.Add(this.btn_KayitOl);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Soyad);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_HesapNo);
            this.Controls.Add(this.txt_Ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.TextBox txt_HesapNo;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_KayitOl;
        private System.Windows.Forms.Button btn_SifreGuncelle;
        private System.Windows.Forms.Button btn_KullaniciSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_MusteriGoruntule;
        private System.Windows.Forms.Button btn_MusteriUret;
    }
}

