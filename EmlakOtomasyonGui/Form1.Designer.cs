namespace EmlakOtomasyonGui
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
            btn_yeniEvEkleme = new Button();
            btn_sorgula = new Button();
            btn_duzenle = new Button();
            SuspendLayout();
            // 
            // btn_yeniEvEkleme
            // 
            btn_yeniEvEkleme.Location = new Point(12, 12);
            btn_yeniEvEkleme.Name = "btn_yeniEvEkleme";
            btn_yeniEvEkleme.Size = new Size(240, 36);
            btn_yeniEvEkleme.TabIndex = 0;
            btn_yeniEvEkleme.Text = "Yeni Ev Ekle";
            btn_yeniEvEkleme.UseVisualStyleBackColor = true;
            btn_yeniEvEkleme.Click += btn_yeniEvEkleme_Click;
            // 
            // btn_sorgula
            // 
            btn_sorgula.Location = new Point(12, 54);
            btn_sorgula.Name = "btn_sorgula";
            btn_sorgula.Size = new Size(240, 36);
            btn_sorgula.TabIndex = 0;
            btn_sorgula.Text = "Sorgula";
            btn_sorgula.UseVisualStyleBackColor = true;
            // 
            // btn_duzenle
            // 
            btn_duzenle.Location = new Point(12, 96);
            btn_duzenle.Name = "btn_duzenle";
            btn_duzenle.Size = new Size(240, 36);
            btn_duzenle.TabIndex = 0;
            btn_duzenle.Text = "Düzenle";
            btn_duzenle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_duzenle);
            Controls.Add(btn_sorgula);
            Controls.Add(btn_yeniEvEkleme);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_yeniEvEkleme;
        private Button btn_sorgula;
        private Button btn_duzenle;
    }
}
