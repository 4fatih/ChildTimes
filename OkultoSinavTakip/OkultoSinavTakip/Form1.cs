namespace OkultoSinavTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 191, 255);

        }

        private void BtnSari_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(250, 255, 14);
        }

        private void BtnTuruncu_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 159, 14);
        }

        private void BtnBeyaz_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void BtnPembe_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(248, 7, 253);
        }

        private void BtnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(54, 151, 8);
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sinav1, sinav2, sinav3, proje, Ortalama;
        }
    }
}
