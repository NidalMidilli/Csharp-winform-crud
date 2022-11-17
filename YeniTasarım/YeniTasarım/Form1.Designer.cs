namespace YeniTasarım
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtg_ogrenci = new System.Windows.Forms.DataGridView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.txt_ogrencino = new System.Windows.Forms.TextBox();
            this.txt_oisim = new System.Windows.Forms.TextBox();
            this.txt_osoyisim = new System.Windows.Forms.TextBox();
            this.txt_osehir = new System.Windows.Forms.TextBox();
            this.lbl_numara = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_sehir = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ogrenci)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_ogrenci
            // 
            this.dtg_ogrenci.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dtg_ogrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_ogrenci.Location = new System.Drawing.Point(90, 12);
            this.dtg_ogrenci.Name = "dtg_ogrenci";
            this.dtg_ogrenci.RowTemplate.Height = 25;
            this.dtg_ogrenci.Size = new System.Drawing.Size(615, 150);
            this.dtg_ogrenci.TabIndex = 0;
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.Lime;
            this.btn_ekle.Location = new System.Drawing.Point(51, 22);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(96, 30);
            this.btn_ekle.TabIndex = 1;
            this.btn_ekle.Text = "EKLE";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.BackColor = System.Drawing.Color.Yellow;
            this.btn_guncelle.Location = new System.Drawing.Point(51, 63);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(96, 32);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "GÜNCELLE";
            this.btn_guncelle.UseVisualStyleBackColor = false;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.Red;
            this.btn_sil.Location = new System.Drawing.Point(51, 104);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(96, 30);
            this.btn_sil.TabIndex = 3;
            this.btn_sil.Text = "SİL";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // txt_ogrencino
            // 
            this.txt_ogrencino.Location = new System.Drawing.Point(80, 23);
            this.txt_ogrencino.Name = "txt_ogrencino";
            this.txt_ogrencino.Size = new System.Drawing.Size(100, 23);
            this.txt_ogrencino.TabIndex = 4;
            // 
            // txt_oisim
            // 
            this.txt_oisim.Location = new System.Drawing.Point(80, 52);
            this.txt_oisim.Name = "txt_oisim";
            this.txt_oisim.Size = new System.Drawing.Size(100, 23);
            this.txt_oisim.TabIndex = 5;
            // 
            // txt_osoyisim
            // 
            this.txt_osoyisim.Location = new System.Drawing.Point(80, 81);
            this.txt_osoyisim.Name = "txt_osoyisim";
            this.txt_osoyisim.Size = new System.Drawing.Size(100, 23);
            this.txt_osoyisim.TabIndex = 6;
            // 
            // txt_osehir
            // 
            this.txt_osehir.Location = new System.Drawing.Point(80, 110);
            this.txt_osehir.Name = "txt_osehir";
            this.txt_osehir.Size = new System.Drawing.Size(100, 23);
            this.txt_osehir.TabIndex = 7;
            // 
            // lbl_numara
            // 
            this.lbl_numara.AutoSize = true;
            this.lbl_numara.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbl_numara.Location = new System.Drawing.Point(6, 26);
            this.lbl_numara.Name = "lbl_numara";
            this.lbl_numara.Size = new System.Drawing.Size(68, 15);
            this.lbl_numara.TabIndex = 8;
            this.lbl_numara.Text = "Öğrenci No";
            this.lbl_numara.Click += new System.EventHandler(this.lbl_numara_Click);
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbl_ad.Location = new System.Drawing.Point(45, 55);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(23, 15);
            this.lbl_ad.TabIndex = 9;
            this.lbl_ad.Text = "AD";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbl_soyad.Location = new System.Drawing.Point(30, 84);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(44, 15);
            this.lbl_soyad.TabIndex = 10;
            this.lbl_soyad.Text = "SOYAD";
            // 
            // lbl_sehir
            // 
            this.lbl_sehir.AutoSize = true;
            this.lbl_sehir.ForeColor = System.Drawing.Color.Aquamarine;
            this.lbl_sehir.Location = new System.Drawing.Point(30, 113);
            this.lbl_sehir.Name = "lbl_sehir";
            this.lbl_sehir.Size = new System.Drawing.Size(38, 15);
            this.lbl_sehir.TabIndex = 11;
            this.lbl_sehir.Text = "ŞEHİR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ekle);
            this.groupBox1.Controls.Add(this.btn_guncelle);
            this.groupBox1.Controls.Add(this.btn_sil);
            this.groupBox1.Location = new System.Drawing.Point(90, 213);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 152);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_numara);
            this.groupBox2.Controls.Add(this.txt_ogrencino);
            this.groupBox2.Controls.Add(this.lbl_sehir);
            this.groupBox2.Controls.Add(this.txt_oisim);
            this.groupBox2.Controls.Add(this.lbl_soyad);
            this.groupBox2.Controls.Add(this.txt_osoyisim);
            this.groupBox2.Controls.Add(this.lbl_ad);
            this.groupBox2.Controls.Add(this.txt_osehir);
            this.groupBox2.Location = new System.Drawing.Point(505, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 146);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Öğrenci Bilgileri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtg_ogrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ogrenci)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_ogrenci;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.TextBox txt_ogrencino;
        private System.Windows.Forms.TextBox txt_oisim;
        private System.Windows.Forms.TextBox txt_osoyisim;
        private System.Windows.Forms.TextBox txt_osehir;
        private System.Windows.Forms.Label lbl_numara;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_sehir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
