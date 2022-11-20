namespace Идти_или_нахуй
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r= new Random();
            if (r.Next(100) == 1) 
            {
                MessageBox.Show($"Идём на пару {textBox1.Text}"); 
            }
            else
            {
                MessageBox.Show($"Нахуй пару {textBox1.Text}");
            }
        }
    }
}