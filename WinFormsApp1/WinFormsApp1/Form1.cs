namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int textbox2 = Convert.ToInt32(textBox2.Text);
            string total = Convert.ToString(textbox1 + textbox2);
            MessageBox.Show(total);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int textbox2 = Convert.ToInt32(textBox2.Text);
            string total = Convert.ToString(textbox1 - textbox2);
            label3.Text = total;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int textbox2 = Convert.ToInt32(textBox2.Text);
            string total = Convert.ToString(textbox1 * textbox2);
            label3.Text = total;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int textbox1 = Convert.ToInt32(textBox1.Text);
            int textbox2 = Convert.ToInt32(textBox2.Text);
            string total = Convert.ToString(textbox1 / textbox2);
            label3.Text = total;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";

            textBox1.BackColor = Color.Blue;
            textBox2.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 force = new Form2();
            force.Show();
        }
    }
}