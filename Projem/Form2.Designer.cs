
namespace Projem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.comboBox_Hesaplar = new System.Windows.Forms.ComboBox();
            this.comboBox_Transferler = new System.Windows.Forms.ComboBox();
            this.comboBox_Odemeler = new System.Windows.Forms.ComboBox();
            this.comboBox_Kartlar = new System.Windows.Forms.ComboBox();
            this.comboBox_Yatirimlar = new System.Windows.Forms.ComboBox();
            this.btn_GecmisIslemler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Hesaplar
            // 
            this.comboBox_Hesaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Hesaplar.FormattingEnabled = true;
            this.comboBox_Hesaplar.Items.AddRange(new object[] {
            "Açılış",
            "Kapanış",
            "Liste"});
            this.comboBox_Hesaplar.Location = new System.Drawing.Point(141, 373);
            this.comboBox_Hesaplar.Name = "comboBox_Hesaplar";
            this.comboBox_Hesaplar.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Hesaplar.TabIndex = 0;
            this.comboBox_Hesaplar.Text = "Hesaplar";
            // 
            // comboBox_Transferler
            // 
            this.comboBox_Transferler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Transferler.FormattingEnabled = true;
            this.comboBox_Transferler.Items.AddRange(new object[] {
            "Havale",
            "EFT"});
            this.comboBox_Transferler.Location = new System.Drawing.Point(453, 171);
            this.comboBox_Transferler.Name = "comboBox_Transferler";
            this.comboBox_Transferler.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Transferler.TabIndex = 1;
            this.comboBox_Transferler.Text = "Transferler";
            // 
            // comboBox_Odemeler
            // 
            this.comboBox_Odemeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Odemeler.FormattingEnabled = true;
            this.comboBox_Odemeler.Items.AddRange(new object[] {
            "Kredi Ödemeleri",
            "Fatura Ödeme"});
            this.comboBox_Odemeler.Location = new System.Drawing.Point(141, 171);
            this.comboBox_Odemeler.Name = "comboBox_Odemeler";
            this.comboBox_Odemeler.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Odemeler.TabIndex = 2;
            this.comboBox_Odemeler.Text = "Ödemeler";
            this.comboBox_Odemeler.SelectedIndexChanged += new System.EventHandler(this.comboBox_Odemeler_SelectedIndexChanged);
            // 
            // comboBox_Kartlar
            // 
            this.comboBox_Kartlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Kartlar.FormattingEnabled = true;
            this.comboBox_Kartlar.Items.AddRange(new object[] {
            "Detay",
            "Dönem İçi İşlemler",
            "Ekstre Gösterimi",
            "Kart Borcu Ödeme"});
            this.comboBox_Kartlar.Location = new System.Drawing.Point(314, 90);
            this.comboBox_Kartlar.Name = "comboBox_Kartlar";
            this.comboBox_Kartlar.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Kartlar.TabIndex = 3;
            this.comboBox_Kartlar.Text = "Kartlar";
            // 
            // comboBox_Yatirimlar
            // 
            this.comboBox_Yatirimlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox_Yatirimlar.FormattingEnabled = true;
            this.comboBox_Yatirimlar.Items.AddRange(new object[] {
            "Döviz Alış",
            "Döviz Satış",
            "Kur Bilgileri"});
            this.comboBox_Yatirimlar.Location = new System.Drawing.Point(453, 373);
            this.comboBox_Yatirimlar.Name = "comboBox_Yatirimlar";
            this.comboBox_Yatirimlar.Size = new System.Drawing.Size(175, 28);
            this.comboBox_Yatirimlar.TabIndex = 4;
            this.comboBox_Yatirimlar.Text = "Yatırımlar";
            this.comboBox_Yatirimlar.SelectedIndexChanged += new System.EventHandler(this.comboBox_Yatirimlar_SelectedIndexChanged);
            // 
            // btn_GecmisIslemler
            // 
            this.btn_GecmisIslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_GecmisIslemler.ForeColor = System.Drawing.Color.Red;
            this.btn_GecmisIslemler.Location = new System.Drawing.Point(314, 251);
            this.btn_GecmisIslemler.Name = "btn_GecmisIslemler";
            this.btn_GecmisIslemler.Size = new System.Drawing.Size(175, 59);
            this.btn_GecmisIslemler.TabIndex = 5;
            this.btn_GecmisIslemler.Text = "Geçmiş İşlemler";
            this.btn_GecmisIslemler.UseVisualStyleBackColor = true;
            this.btn_GecmisIslemler.Click += new System.EventHandler(this.btn_GecmisIslemler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(522, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bugün Hangi Banka İşleminizi Yapacaksınız?";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(685, 121);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(476, 280);
            this.dataGridView2.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 443);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GecmisIslemler);
            this.Controls.Add(this.comboBox_Yatirimlar);
            this.Controls.Add(this.comboBox_Kartlar);
            this.Controls.Add(this.comboBox_Odemeler);
            this.Controls.Add(this.comboBox_Transferler);
            this.Controls.Add(this.comboBox_Hesaplar);
            this.ForeColor = System.Drawing.Color.Cyan;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UYGULAMA";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Hesaplar;
        private System.Windows.Forms.ComboBox comboBox_Transferler;
        private System.Windows.Forms.ComboBox comboBox_Odemeler;
        private System.Windows.Forms.ComboBox comboBox_Kartlar;
        private System.Windows.Forms.ComboBox comboBox_Yatirimlar;
        private System.Windows.Forms.Button btn_GecmisIslemler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}