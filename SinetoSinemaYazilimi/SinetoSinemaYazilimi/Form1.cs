namespace SinetoSinemaYazilimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int su, bilet, misir, cay, sut, toplam;
            bilet = Convert.ToInt16(biletS.Text);
            su = Convert.ToInt16(suS.Text);
            misir = Convert.ToInt16(misirS.Text);
            cay = Convert.ToInt16(cayS.Text);
            sut = Convert.ToInt16(sutS.Text);
            toplam = bilet * 250 + misir * 5 + sut * 10 + cay * 5 + su * 5;

            lblToplam.Text = toplam.ToString() + "TL";
        }
    }
}
