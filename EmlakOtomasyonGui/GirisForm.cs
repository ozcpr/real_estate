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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void btn_girisYap_Click(object sender, EventArgs e)
        {
            // temp credentials
            string username = "admin";
            string password = "12345";

            if (txt_kullaniciAdi.Text == username && txt_sifre.Text == password)
            {
                // Login logic
                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 mainForm = new Form1();
                mainForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {

                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
