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


        private static readonly string BasePath = @"C:\Users\OZANCRP\source\repos\emlak_otomasyonu";
        private static readonly string KiralikFilePath = System.IO.Path.Combine(BasePath, "kiralik.txt");
        private static readonly string SatilikFilePath = System.IO.Path.Combine(BasePath, "satilik.txt");


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
                    evListesi.Add(satilikEv);
                }

                MessageBox.Show("Ev başarıyla eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DosyayaKaydet();
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

        public static void DosyayaKaydet()
        {
            using (StreamWriter writer = new StreamWriter(KiralikFilePath, false))
            {
                foreach (var ev in evListesi)
                {
                    if (ev is KiralikEv kiralikEv)
                    {
                        writer.WriteLine($"{kiralikEv.OdaSayisi},{kiralikEv.KatNumarasi},{kiralikEv.Semti},{kiralikEv.Alani},{kiralikEv.YapimTarihi},{kiralikEv.Turu},{kiralikEv.EmlakNumarasi},{kiralikEv.Depozito}");
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(SatilikFilePath, false))
            {
                foreach (var ev in evListesi)
                {
                    if (ev is SatilikEv satilikEv)
                    {
                        writer.WriteLine($"{satilikEv.OdaSayisi},{satilikEv.KatNumarasi},{satilikEv.Semti},{satilikEv.Alani},{satilikEv.YapimTarihi},{satilikEv.Turu},{satilikEv.EmlakNumarasi},{satilikEv.Fiyat}");
                    }
                }
            }
        }


        public static void DosyadanOku()
        {
            evListesi.Clear();

            if (File.Exists(KiralikFilePath))
            {
                using (StreamReader reader = new StreamReader(KiralikFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        KiralikEv kiralikEv = new KiralikEv(
                            odaSayisi: int.Parse(data[0]),
                            katNumarasi: int.Parse(data[1]),
                            semti: data[2],
                            alani: double.Parse(data[3]),
                            yapimTarihi: int.Parse(data[4]),
                            turu: (EmlakTuru)Enum.Parse(typeof(EmlakTuru), data[5]),
                            emlakNumarasi: int.Parse(data[6]),
                            depozito: double.Parse(data[7])
                        );
                        evListesi.Add(kiralikEv);
                    }
                }
            }


            if (File.Exists(SatilikFilePath))
            {
                using (StreamReader reader = new StreamReader(SatilikFilePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        SatilikEv satilikEv = new SatilikEv(
                            odaSayisi: int.Parse(data[0]),
                            katNumarasi: int.Parse(data[1]),
                            semti: data[2],
                            alani: double.Parse(data[3]),
                            yapimTarihi: int.Parse(data[4]),
                            turu: (EmlakTuru)Enum.Parse(typeof(EmlakTuru), data[5]),
                            emlakNumarasi: int.Parse(data[6]),
                            fiyat: double.Parse(data[7])
                        );
                        evListesi.Add(satilikEv);
                    }
                }
            }
        }

    }
}
