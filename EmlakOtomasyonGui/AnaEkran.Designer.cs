namespace EmlakOtomasyonGui
{
    partial class AnaEkran
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
            SuspendLayout();
            // 
            // btn_yeniEvEkleme
            // 
            btn_yeniEvEkleme.BackColor = SystemColors.Control;
            btn_yeniEvEkleme.Location = new Point(280, 178);
            btn_yeniEvEkleme.Name = "btn_yeniEvEkleme";
            btn_yeniEvEkleme.Size = new Size(240, 36);
            btn_yeniEvEkleme.TabIndex = 0;
            btn_yeniEvEkleme.Text = "+ Yeni Ev Ekle";
            btn_yeniEvEkleme.UseVisualStyleBackColor = false;
            btn_yeniEvEkleme.Click += btn_yeniEvEkleme_Click;
            // 
            // btn_sorgula
            // 
            btn_sorgula.BackColor = SystemColors.ControlDark;
            btn_sorgula.Location = new Point(280, 236);
            btn_sorgula.Name = "btn_sorgula";
            btn_sorgula.Size = new Size(240, 36);
            btn_sorgula.TabIndex = 0;
            btn_sorgula.Text = "Sorgula";
            btn_sorgula.UseVisualStyleBackColor = false;
            btn_sorgula.Click += btn_sorgula_Click;
            // 
            // AnaEkran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_sorgula);
            Controls.Add(btn_yeniEvEkleme);
            Name = "AnaEkran";
            Text = "Real Estate";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_yeniEvEkleme;
        private Button btn_sorgula;
    }
}
