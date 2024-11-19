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

namespace EmlakOtomasyonGui
{
    public partial class EvleriListeleForm : Form
    {
        public EvleriListeleForm()
        {
            InitializeComponent();
        }



        private void EvleriListeleForm_Load(object sender, EventArgs e)
        {

            YeniEvEkleForm.DosyadanOku(); // load data from file

            // Populating the dgw
            dgv_evListesi.DataSource = null;
            dgv_evListesi.DataSource = YeniEvEkleForm.evListesi;

            dgv_evListesi.Refresh();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            YeniEvEkleForm.DosyadanOku(); // load data from file

            dgv_evListesi.DataSource = null;
            dgv_evListesi.DataSource = YeniEvEkleForm.evListesi;

            dgv_evListesi.Refresh();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (dgv_evListesi.CurrentRow != null)
            {

                int selectedIndex = dgv_evListesi.CurrentRow.Index;

                DialogResult result = MessageBox.Show("Bu evi silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    YeniEvEkleForm.evListesi.RemoveAt(selectedIndex);

                    YeniEvEkleForm.DosyayaKaydet(); // save data to file

                    dgv_evListesi.DataSource = null;
                    dgv_evListesi.DataSource = YeniEvEkleForm.evListesi;
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz evi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_düzenle_Click(object sender, EventArgs e)
        {
            if (dgv_evListesi.CurrentRow != null)
            {

                int selectedIndex = dgv_evListesi.CurrentRow.Index;
                Ev selectedEv = YeniEvEkleForm.evListesi[selectedIndex];

                YeniEvEkleForm.DosyayaKaydet(); // save data to file


                EvDuzenleForm evDuzenleForm = new EvDuzenleForm(selectedEv, selectedIndex);
                evDuzenleForm.ShowDialog();


                dgv_evListesi.DataSource = null;
                dgv_evListesi.DataSource = YeniEvEkleForm.evListesi;
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz evi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
