﻿namespace EmlakOtomasyonGui
{
    partial class EvDuzenleForm
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
            rdb_satilik = new RadioButton();
            rdb_kiralik = new RadioButton();
            txt_fiyat = new TextBox();
            txt_depozito = new TextBox();
            txt_yapimTarihi = new TextBox();
            txt_alani = new TextBox();
            txt_semti = new TextBox();
            txt_katNumarasi = new TextBox();
            txt_odaSayisi = new TextBox();
            btn_kaydet = new Button();
            cmb_turu = new ComboBox();
            lbl_fiyat = new Label();
            lbl_depozito = new Label();
            lbl_durum = new Label();
            lbl_turu = new Label();
            lbl_yapımTarihi = new Label();
            lbl_alani = new Label();
            lbl_semti = new Label();
            lbl_katNumarasi = new Label();
            lbl_odaSayisi = new Label();
            SuspendLayout();
            // 
            // rdb_satilik
            // 
            rdb_satilik.AutoSize = true;
            rdb_satilik.Location = new Point(483, 292);
            rdb_satilik.Name = "rdb_satilik";
            rdb_satilik.Size = new Size(56, 19);
            rdb_satilik.TabIndex = 24;
            rdb_satilik.TabStop = true;
            rdb_satilik.Text = "Satılık";
            rdb_satilik.UseVisualStyleBackColor = true;
            rdb_satilik.CheckedChanged += rdb_satilik_CheckedChanged;
            // 
            // rdb_kiralik
            // 
            rdb_kiralik.AutoSize = true;
            rdb_kiralik.Location = new Point(409, 292);
            rdb_kiralik.Name = "rdb_kiralik";
            rdb_kiralik.Size = new Size(57, 19);
            rdb_kiralik.TabIndex = 23;
            rdb_kiralik.TabStop = true;
            rdb_kiralik.Text = "Kiralık";
            rdb_kiralik.UseVisualStyleBackColor = true;
            rdb_kiralik.CheckedChanged += rdb_kiralik_CheckedChanged;
            // 
            // txt_fiyat
            // 
            txt_fiyat.AccessibleDescription = "Show only if satilik selected";
            txt_fiyat.Location = new Point(409, 228);
            txt_fiyat.Name = "txt_fiyat";
            txt_fiyat.Size = new Size(130, 23);
            txt_fiyat.TabIndex = 21;
            // 
            // txt_depozito
            // 
            txt_depozito.AccessibleDescription = "Show only if kiralik selected";
            txt_depozito.Location = new Point(409, 228);
            txt_depozito.Name = "txt_depozito";
            txt_depozito.Size = new Size(130, 23);
            txt_depozito.TabIndex = 20;
            // 
            // txt_yapimTarihi
            // 
            txt_yapimTarihi.Location = new Point(409, 155);
            txt_yapimTarihi.Name = "txt_yapimTarihi";
            txt_yapimTarihi.Size = new Size(130, 23);
            txt_yapimTarihi.TabIndex = 19;
            // 
            // txt_alani
            // 
            txt_alani.Location = new Point(409, 124);
            txt_alani.Name = "txt_alani";
            txt_alani.Size = new Size(130, 23);
            txt_alani.TabIndex = 18;
            // 
            // txt_semti
            // 
            txt_semti.Location = new Point(409, 87);
            txt_semti.Name = "txt_semti";
            txt_semti.Size = new Size(130, 23);
            txt_semti.TabIndex = 17;
            // 
            // txt_katNumarasi
            // 
            txt_katNumarasi.Location = new Point(409, 58);
            txt_katNumarasi.Name = "txt_katNumarasi";
            txt_katNumarasi.Size = new Size(130, 23);
            txt_katNumarasi.TabIndex = 16;
            // 
            // txt_odaSayisi
            // 
            txt_odaSayisi.Location = new Point(409, 30);
            txt_odaSayisi.Name = "txt_odaSayisi";
            txt_odaSayisi.Size = new Size(130, 23);
            txt_odaSayisi.TabIndex = 22;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(267, 358);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(272, 43);
            btn_kaydet.TabIndex = 15;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // cmb_turu
            // 
            cmb_turu.FormattingEnabled = true;
            cmb_turu.Location = new Point(409, 185);
            cmb_turu.Name = "cmb_turu";
            cmb_turu.Size = new Size(130, 23);
            cmb_turu.TabIndex = 14;
            cmb_turu.Text = "Seçiniz";
            // 
            // lbl_fiyat
            // 
            lbl_fiyat.AccessibleDescription = "Show only if satilik selected";
            lbl_fiyat.AutoSize = true;
            lbl_fiyat.Location = new Point(267, 225);
            lbl_fiyat.Name = "lbl_fiyat";
            lbl_fiyat.Size = new Size(38, 15);
            lbl_fiyat.TabIndex = 12;
            lbl_fiyat.Text = "Fiyat :";
            // 
            // lbl_depozito
            // 
            lbl_depozito.AccessibleDescription = "Show only if kiralik selected";
            lbl_depozito.AutoSize = true;
            lbl_depozito.Location = new Point(267, 257);
            lbl_depozito.Name = "lbl_depozito";
            lbl_depozito.Size = new Size(60, 15);
            lbl_depozito.TabIndex = 11;
            lbl_depozito.Text = "Depozito :";
            // 
            // lbl_durum
            // 
            lbl_durum.AutoSize = true;
            lbl_durum.Location = new Point(267, 289);
            lbl_durum.Name = "lbl_durum";
            lbl_durum.Size = new Size(72, 15);
            lbl_durum.TabIndex = 10;
            lbl_durum.Text = "Ev Durumu :";
            // 
            // lbl_turu
            // 
            lbl_turu.AutoSize = true;
            lbl_turu.Location = new Point(267, 193);
            lbl_turu.Name = "lbl_turu";
            lbl_turu.Size = new Size(37, 15);
            lbl_turu.TabIndex = 9;
            lbl_turu.Text = "Türü :";
            // 
            // lbl_yapımTarihi
            // 
            lbl_yapımTarihi.AutoSize = true;
            lbl_yapımTarihi.Location = new Point(267, 161);
            lbl_yapımTarihi.Name = "lbl_yapımTarihi";
            lbl_yapımTarihi.Size = new Size(77, 15);
            lbl_yapımTarihi.TabIndex = 8;
            lbl_yapımTarihi.Text = "Yapım Tarihi :";
            // 
            // lbl_alani
            // 
            lbl_alani.AutoSize = true;
            lbl_alani.Location = new Point(267, 129);
            lbl_alani.Name = "lbl_alani";
            lbl_alani.Size = new Size(40, 15);
            lbl_alani.TabIndex = 7;
            lbl_alani.Text = "Alanı :";
            // 
            // lbl_semti
            // 
            lbl_semti.AutoSize = true;
            lbl_semti.Location = new Point(267, 97);
            lbl_semti.Name = "lbl_semti";
            lbl_semti.Size = new Size(43, 15);
            lbl_semti.TabIndex = 6;
            lbl_semti.Text = "Semti :";
            // 
            // lbl_katNumarasi
            // 
            lbl_katNumarasi.AutoSize = true;
            lbl_katNumarasi.Location = new Point(267, 65);
            lbl_katNumarasi.Name = "lbl_katNumarasi";
            lbl_katNumarasi.Size = new Size(84, 15);
            lbl_katNumarasi.TabIndex = 13;
            lbl_katNumarasi.Text = "Kat Numarası :";
            // 
            // lbl_odaSayisi
            // 
            lbl_odaSayisi.AutoSize = true;
            lbl_odaSayisi.Location = new Point(267, 25);
            lbl_odaSayisi.Name = "lbl_odaSayisi";
            lbl_odaSayisi.Size = new Size(67, 15);
            lbl_odaSayisi.TabIndex = 5;
            lbl_odaSayisi.Text = "Oda Sayısı :";
            // 
            // EvDuzenleForm
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
            Name = "EvDuzenleForm";
            Text = "EvDuzenleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdb_satilik;
        private RadioButton rdb_kiralik;
        private TextBox txt_fiyat;
        private TextBox txt_depozito;
        private TextBox txt_yapimTarihi;
        private TextBox txt_alani;
        private TextBox txt_semti;
        private TextBox txt_katNumarasi;
        private TextBox txt_odaSayisi;
        private Button btn_kaydet;
        private ComboBox cmb_turu;
        private Label lbl_fiyat;
        private Label lbl_depozito;
        private Label lbl_durum;
        private Label lbl_turu;
        private Label lbl_yapımTarihi;
        private Label lbl_alani;
        private Label lbl_semti;
        private Label lbl_katNumarasi;
        private Label lbl_odaSayisi;
    }
}