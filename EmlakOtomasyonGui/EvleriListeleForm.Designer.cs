namespace EmlakOtomasyonGui
{
    partial class EvleriListeleForm
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
            dgv_evListesi = new DataGridView();
            btn_yenile = new Button();
            btn_düzenle = new Button();
            btn_sil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_evListesi).BeginInit();
            SuspendLayout();
            // 
            // dgv_evListesi
            // 
            dgv_evListesi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_evListesi.Location = new Point(12, 12);
            dgv_evListesi.Name = "dgv_evListesi";
            dgv_evListesi.Size = new Size(1141, 371);
            dgv_evListesi.TabIndex = 0;
            // 
            // btn_yenile
            // 
            btn_yenile.BackColor = SystemColors.Control;
            btn_yenile.Location = new Point(12, 406);
            btn_yenile.Name = "btn_yenile";
            btn_yenile.Size = new Size(113, 32);
            btn_yenile.TabIndex = 1;
            btn_yenile.Text = "Yenile";
            btn_yenile.UseVisualStyleBackColor = false;
            btn_yenile.Click += btn_yenile_Click;
            // 
            // btn_düzenle
            // 
            btn_düzenle.BackColor = SystemColors.ControlDark;
            btn_düzenle.FlatAppearance.BorderColor = Color.Black;
            btn_düzenle.FlatAppearance.BorderSize = 5;
            btn_düzenle.Location = new Point(141, 406);
            btn_düzenle.Name = "btn_düzenle";
            btn_düzenle.Size = new Size(113, 32);
            btn_düzenle.TabIndex = 1;
            btn_düzenle.Text = "Düzenle";
            btn_düzenle.UseVisualStyleBackColor = false;
            btn_düzenle.Click += btn_düzenle_Click;
            // 
            // btn_sil
            // 
            btn_sil.BackColor = Color.IndianRed;
            btn_sil.Location = new Point(270, 406);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(113, 32);
            btn_sil.TabIndex = 1;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = false;
            btn_sil.Click += btn_sil_Click;
            // 
            // EvleriListeleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 450);
            Controls.Add(btn_sil);
            Controls.Add(btn_düzenle);
            Controls.Add(btn_yenile);
            Controls.Add(dgv_evListesi);
            Name = "EvleriListeleForm";
            Text = "EvleriListeleForm";
            Load += EvleriListeleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_evListesi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_evListesi;
        private Button btn_yenile;
        private Button btn_düzenle;
        private Button btn_sil;
    }
}