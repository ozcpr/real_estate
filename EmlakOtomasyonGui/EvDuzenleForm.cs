using EmlakOtomasyonLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EmlakOtomasyonLibrary.Ev;

namespace EmlakOtomasyonGui
{
    public partial class EvDuzenleForm : Form
    {
        public EvDuzenleForm()
        {
            InitializeComponent();
        }

        #region Constructor for EvleriDüzenleForm

        private Ev ev;
        private int index;

        public EvDuzenleForm(Ev selectedEv, int selectedIndex)
        {
            InitializeComponent();
            this.ev = selectedEv;
            this.index = selectedIndex;

            txt_odaSayisi.Text = ev.OdaSayisi.ToString();
            txt_katNumarasi.Text = ev.KatNumarasi.ToString();
            txt_semti.Text = ev.Semti;
            txt_alani.Text = ev.Alani.ToString();
            txt_yapimTarihi.Text = ev.YapimTarihi.ToString();
            cmb_turu.DataSource = Enum.GetValues(typeof(EmlakTuru));
            cmb_turu.SelectedItem = ev.Turu;

            // Ev kiralik or not ?
            if (ev is KiralikEv kiralikEv)
            {
                rdb_kiralik.Checked = true;
                txt_depozito.Text = kiralikEv.Depozito.ToString();
                lbl_depozito.Visible = true;
                txt_depozito.Visible = true;
                lbl_fiyat.Visible = false;
                txt_fiyat.Visible = false;
            }
            else if (ev is SatilikEv satilikEv)
            {
                rdb_satilik.Checked = true;
                txt_fiyat.Text = satilikEv.Fiyat.ToString();
                lbl_depozito.Visible = false;
                txt_depozito.Visible = false;
                lbl_fiyat.Visible = true;
                txt_fiyat.Visible = true;
            }
        }


        #endregion

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Update the fields of the selected prop
                ev.OdaSayisi = int.Parse(txt_odaSayisi.Text);
                ev.KatNumarasi = int.Parse(txt_katNumarasi.Text);
                ev.Semti = txt_semti.Text;
                ev.Alani = double.Parse(txt_alani.Text);
                ev.YapimTarihi = int.Parse(txt_yapimTarihi.Text);
                ev.Turu = (EmlakTuru)cmb_turu.SelectedItem;

                if (rdb_kiralik.Checked && ev is KiralikEv kiralikEv)
                {
                    kiralikEv.Depozito = double.Parse(txt_depozito.Text);
                }
                else if (rdb_satilik.Checked && ev is SatilikEv satilikEv)
                {
                    satilikEv.Fiyat = double.Parse(txt_fiyat.Text);
                }

                // Updating the list
                YeniEvEkleForm.evListesi[index] = ev;

                MessageBox.Show("Ev bilgileri başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                YeniEvEkleForm.DosyayaKaydet();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdb_kiralik_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_kiralik.Checked)
            {
                lbl_depozito.Visible = true;
                txt_depozito.Visible = true;
                lbl_fiyat.Visible = false;
                txt_fiyat.Visible = false;
            }
        }

        private void rdb_satilik_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_satilik.Checked)
            {
                lbl_depozito.Visible = false;
                txt_depozito.Visible = false;
                lbl_fiyat.Visible = true;
                txt_fiyat.Visible = true;
            }
        }
    }
}
