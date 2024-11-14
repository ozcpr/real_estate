namespace EmlakOtomasyonGui
{
    partial class GirisForm
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
            lbl_kullaniciAdi = new Label();
            txt_kullaniciAdi = new TextBox();
            lbl_sifre = new Label();
            txt_sifre = new TextBox();
            btn_girisYap = new Button();
            SuspendLayout();
            // 
            // lbl_kullaniciAdi
            // 
            lbl_kullaniciAdi.AutoSize = true;
            lbl_kullaniciAdi.Location = new Point(256, 139);
            lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            lbl_kullaniciAdi.Size = new Size(79, 15);
            lbl_kullaniciAdi.TabIndex = 0;
            lbl_kullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // txt_kullaniciAdi
            // 
            txt_kullaniciAdi.Location = new Point(364, 136);
            txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            txt_kullaniciAdi.Size = new Size(181, 23);
            txt_kullaniciAdi.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            lbl_sifre.AutoSize = true;
            lbl_sifre.Location = new Point(256, 196);
            lbl_sifre.Name = "lbl_sifre";
            lbl_sifre.Size = new Size(36, 15);
            lbl_sifre.TabIndex = 0;
            lbl_sifre.Text = "Şifre :";
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(364, 193);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(181, 23);
            txt_sifre.TabIndex = 1;
            txt_sifre.Text = "passwdcharnotactive";
            txt_sifre.UseSystemPasswordChar = true;
            // 
            // btn_girisYap
            // 
            btn_girisYap.Location = new Point(256, 272);
            btn_girisYap.Name = "btn_girisYap";
            btn_girisYap.Size = new Size(289, 42);
            btn_girisYap.TabIndex = 2;
            btn_girisYap.Text = "Giriş Yap";
            btn_girisYap.UseVisualStyleBackColor = true;
            btn_girisYap.Click += btn_girisYap_Click;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_girisYap);
            Controls.Add(txt_sifre);
            Controls.Add(txt_kullaniciAdi);
            Controls.Add(lbl_sifre);
            Controls.Add(lbl_kullaniciAdi);
            Name = "GirisForm";
            Text = "GirisForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_kullaniciAdi;
        private TextBox txt_kullaniciAdi;
        private Label lbl_sifre;
        private TextBox txt_sifre;
        private Button btn_girisYap;
    }
}