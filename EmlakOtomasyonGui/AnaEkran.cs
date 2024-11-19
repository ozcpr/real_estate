using EmlakOtomasyonGui;


namespace EmlakOtomasyonGui
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btn_yeniEvEkleme_Click(object sender, EventArgs e)
        {
            YeniEvEkleForm yeniEvEkleForm = new YeniEvEkleForm();
            yeniEvEkleForm.ShowDialog();
        }

        private void btn_sorgula_Click(object sender, EventArgs e)
        {
            
                EvleriListeleForm evleriListeleForm = new EvleriListeleForm();
                evleriListeleForm.ShowDialog();
            
                MessageBox.Show($"An error occurred: ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}
