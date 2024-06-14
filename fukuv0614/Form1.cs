namespace fukuv0614
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int ans=0;
        int count = 0;
        int yosou;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            count++;
            MessageBox.Show("$\"{count}‰ñ–Ú‚Ì’§í\"");

           
        }
    }
}