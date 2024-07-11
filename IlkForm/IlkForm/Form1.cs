namespace IlkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + comboBox1.Text + " " + comboBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
