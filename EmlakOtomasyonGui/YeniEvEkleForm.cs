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
    public partial class YeniEvEkleForm : Form
    {
        public YeniEvEkleForm()
        {
            InitializeComponent();
        }

        public static List<Ev> evListesi = new List<Ev>();

        private void YeniEvEkleForm_Load(object sender, EventArgs e)
        {
            cmb_turu.DataSource = Enum.GetValues(typeof(EmlakTuru));
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                int odaSayisi = int.Parse(txt_odaSayisi.Text);
                int katNumarasi = int.Parse(txt_katNumarasi.Text);
                string semti = Convert.ToString(txt_semti.Text);
                double alani = double.Parse(txt_alani.Text);
                int yapimTarihi = int.Parse(txt_yapimTarihi.Text);
                EmlakTuru emlakTuru = cmb_turu.SelectedItem == null ? EmlakTuru.Dubleks : (EmlakTuru)cmb_turu.SelectedItem;
                int emlakNumarasi = new Random().Next(1000, 9999); // temp uniq id

                if (rdb_kiralik.Checked)
                {
                    double depozito = double.Parse(txt_depozito.Text);
                    KiralikEv kiralikEv = new KiralikEv(odaSayisi, katNumarasi, semti, alani, yapimTarihi, emlakTuru, emlakNumarasi, depozito);
                    evListesi.Add(kiralikEv);
                }

                if (rdb_satilik.Checked)
                {
                    double fiyat = double.Parse(txt_fiyat.Text);
                    SatilikEv satilikEv = new SatilikEv(odaSayisi, katNumarasi, semti, alani, yapimTarihi, emlakTuru, emlakNumarasi, fiyat);
                }

                MessageBox.Show("Ev başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
