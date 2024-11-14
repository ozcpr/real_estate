namespace EmlakOtomasyonGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_yeniEvEkleme_Click(object sender, EventArgs e)
        {
            YeniEvEkleForm yeniEvEkleForm = new YeniEvEkleForm();
            yeniEvEkleForm.ShowDialog();
        }
    }
}
