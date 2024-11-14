namespace EmlakOtomasyonGui
{
    partial class YeniEvEkleForm
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
            lbl_odaSayisi = new Label();
            lbl_katNumarasi = new Label();
            lbl_semti = new Label();
            lbl_alani = new Label();
            lbl_yapımTarihi = new Label();
            cmb_turu = new ComboBox();
            lbl_turu = new Label();
            btn_kaydet = new Button();
            txt_odaSayisi = new TextBox();
            txt_katNumarasi = new TextBox();
            txt_semti = new TextBox();
            txt_alani = new TextBox();
            txt_yapimTarihi = new TextBox();
            rdb_kiralik = new RadioButton();
            rdb_satilik = new RadioButton();
            lbl_durum = new Label();
            lbl_depozito = new Label();
            txt_depozito = new TextBox();
            lbl_fiyat = new Label();
            txt_fiyat = new TextBox();
            SuspendLayout();
            // 
            // lbl_odaSayisi
            // 
            lbl_odaSayisi.AutoSize = true;
            lbl_odaSayisi.Location = new Point(12, 9);
            lbl_odaSayisi.Name = "lbl_odaSayisi";
            lbl_odaSayisi.Size = new Size(67, 15);
            lbl_odaSayisi.TabIndex = 0;
            lbl_odaSayisi.Text = "Oda Sayısı :";
            // 
            // lbl_katNumarasi
            // 
            lbl_katNumarasi.AutoSize = true;
            lbl_katNumarasi.Location = new Point(12, 34);
            lbl_katNumarasi.Name = "lbl_katNumarasi";
            lbl_katNumarasi.Size = new Size(84, 15);
            lbl_katNumarasi.TabIndex = 0;
            lbl_katNumarasi.Text = "Kat Numarası :";
            // 
            // lbl_semti
            // 
            lbl_semti.AutoSize = true;
            lbl_semti.Location = new Point(12, 63);
            lbl_semti.Name = "lbl_semti";
            lbl_semti.Size = new Size(43, 15);
            lbl_semti.TabIndex = 0;
            lbl_semti.Text = "Semti :";
            // 
            // lbl_alani
            // 
            lbl_alani.AutoSize = true;
            lbl_alani.Location = new Point(12, 103);
            lbl_alani.Name = "lbl_alani";
            lbl_alani.Size = new Size(40, 15);
            lbl_alani.TabIndex = 0;
            lbl_alani.Text = "Alanı :";
            // 
            // lbl_yapımTarihi
            // 
            lbl_yapımTarihi.AutoSize = true;
            lbl_yapımTarihi.Location = new Point(12, 134);
            lbl_yapımTarihi.Name = "lbl_yapımTarihi";
            lbl_yapımTarihi.Size = new Size(77, 15);
            lbl_yapımTarihi.TabIndex = 0;
            lbl_yapımTarihi.Text = "Yapım Tarihi :";
            // 
            // cmb_turu
            // 
            cmb_turu.FormattingEnabled = true;
            cmb_turu.Location = new Point(154, 161);
            cmb_turu.Name = "cmb_turu";
            cmb_turu.Size = new Size(121, 23);
            cmb_turu.TabIndex = 1;
            cmb_turu.Text = "Seçiniz";
            // 
            // lbl_turu
            // 
            lbl_turu.AutoSize = true;
            lbl_turu.Location = new Point(12, 164);
            lbl_turu.Name = "lbl_turu";
            lbl_turu.Size = new Size(37, 15);
            lbl_turu.TabIndex = 0;
            lbl_turu.Text = "Türü :";
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(234, 261);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(75, 23);
            btn_kaydet.TabIndex = 2;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // txt_odaSayisi
            // 
            txt_odaSayisi.Location = new Point(154, 6);
            txt_odaSayisi.Name = "txt_odaSayisi";
            txt_odaSayisi.Size = new Size(100, 23);
            txt_odaSayisi.TabIndex = 3;
            // 
            // txt_katNumarasi
            // 
            txt_katNumarasi.Location = new Point(154, 34);
            txt_katNumarasi.Name = "txt_katNumarasi";
            txt_katNumarasi.Size = new Size(100, 23);
            txt_katNumarasi.TabIndex = 3;
            // 
            // txt_semti
            // 
            txt_semti.Location = new Point(154, 63);
            txt_semti.Name = "txt_semti";
            txt_semti.Size = new Size(100, 23);
            txt_semti.TabIndex = 3;
            // 
            // txt_alani
            // 
            txt_alani.Location = new Point(154, 100);
            txt_alani.Name = "txt_alani";
            txt_alani.Size = new Size(100, 23);
            txt_alani.TabIndex = 3;
            // 
            // txt_yapimTarihi
            // 
            txt_yapimTarihi.Location = new Point(154, 131);
            txt_yapimTarihi.Name = "txt_yapimTarihi";
            txt_yapimTarihi.Size = new Size(100, 23);
            txt_yapimTarihi.TabIndex = 3;
            // 
            // rdb_kiralik
            // 
            rdb_kiralik.AutoSize = true;
            rdb_kiralik.Location = new Point(197, 203);
            rdb_kiralik.Name = "rdb_kiralik";
            rdb_kiralik.Size = new Size(57, 19);
            rdb_kiralik.TabIndex = 4;
            rdb_kiralik.TabStop = true;
            rdb_kiralik.Text = "Kiralık";
            rdb_kiralik.UseVisualStyleBackColor = true;
            rdb_kiralik.CheckedChanged += rdb_kiralik_CheckedChanged;
            // 
            // rdb_satilik
            // 
            rdb_satilik.AutoSize = true;
            rdb_satilik.Location = new Point(297, 203);
            rdb_satilik.Name = "rdb_satilik";
            rdb_satilik.Size = new Size(56, 19);
            rdb_satilik.TabIndex = 4;
            rdb_satilik.TabStop = true;
            rdb_satilik.Text = "Satılık";
            rdb_satilik.UseVisualStyleBackColor = true;
            rdb_satilik.CheckedChanged += rdb_satilik_CheckedChanged;
            // 
            // lbl_durum
            // 
            lbl_durum.AutoSize = true;
            lbl_durum.Location = new Point(110, 203);
            lbl_durum.Name = "lbl_durum";
            lbl_durum.Size = new Size(72, 15);
            lbl_durum.TabIndex = 0;
            lbl_durum.Text = "Ev Durumu :";
            // 
            // lbl_depozito
            // 
            lbl_depozito.AccessibleDescription = "Show only if kiralik selected";
            lbl_depozito.AutoSize = true;
            lbl_depozito.Location = new Point(322, 15);
            lbl_depozito.Name = "lbl_depozito";
            lbl_depozito.Size = new Size(60, 15);
            lbl_depozito.TabIndex = 0;
            lbl_depozito.Text = "Depozito :";
            // 
            // txt_depozito
            // 
            txt_depozito.AccessibleDescription = "Show only if kiralik selected";
            txt_depozito.Location = new Point(420, 12);
            txt_depozito.Name = "txt_depozito";
            txt_depozito.Size = new Size(100, 23);
            txt_depozito.TabIndex = 3;
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AccessibleDescription = "Show only if satilik selected";
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Location = new Point(322, 52);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(38, 15);
            lbl_fiyat.TabIndex = 0;
            lbl_fiyat.Text = "Fiyat :";
            // 
            // txt_fiyat
            // 
            txt_fiyat.AccessibleDescription = "Show only if satilik selected";
            txt_fiyat.Location = new Point(420, 49);
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(100, 23);
            txt_fiyat.TabIndex = 3;
            // 
            // YeniEvEkleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rdb_satilik);
            Controls.Add(rdb_kiralik);
            Controls.Add(txt_fiyat);
            Controls.Add(txt_depozito);
            Controls.Add(txt_yapimTarihi);
            Controls.Add(txt_alani);
            Controls.Add(txt_semti);
            Controls.Add(txt_katNumarasi);
            Controls.Add(txt_odaSayisi);
            Controls.Add(btn_kaydet);
            Controls.Add(cmb_turu);
            Controls.Add(lbl_fiyat);
            Controls.Add(lbl_depozito);
            Controls.Add(lbl_durum);
            Controls.Add(lbl_turu);
            Controls.Add(lbl_yapımTarihi);
            Controls.Add(lbl_alani);
            Controls.Add(lbl_semti);
            Controls.Add(lbl_katNumarasi);
            Controls.Add(lbl_odaSayisi);
            Name = "YeniEvEkleForm";
            Text = "YeniEvEkleForm";
            Load += YeniEvEkleForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_odaSayisi;
        private Label lbl_katNumarasi;
        private Label lbl_semti;
        private Label lbl_alani;
        private Label lbl_yapımTarihi;
        private ComboBox cmb_turu;
        private Label lbl_turu;
        private Button btn_kaydet;
        private TextBox txt_odaSayisi;
        private TextBox txt_katNumarasi;
        private TextBox txt_semti;
        private TextBox txt_alani;
        private TextBox txt_yapimTarihi;
        private RadioButton rdb_kiralik;
        private RadioButton rdb_satilik;
        private Label lbl_durum;
        private Label lbl_depozito;
        private TextBox txt_depozito;
        private Label lbl_fiyat;
        private TextBox txt_fiyat;
    }
}