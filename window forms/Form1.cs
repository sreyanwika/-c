namespace windowss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int inp1=int.Parse(textBox1.Text);
            int inp2=int.Parse(textBox2.Text);
            int res=inp1 + inp2;
            textBox3.Text = res.ToString();
            MessageBox.Show(textBox3.Text);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
