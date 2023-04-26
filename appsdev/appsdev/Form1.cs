namespace appsdev
{
    public partial class Form1 : Form
    {
        public String inputOne;
        public Form1()
        {
            InitializeComponent();
        }

        public string setValueFirst
        {
            set{
                inputOneBox.Text = value;
            }
        }

        public string setValueSecond
        {
            set{
                inputTwoBox.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel_one.Show();
            panel_two.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel_one.Hide();
            panel_two.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_two.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void home_panel1_Load(object sender, EventArgs e)
        {

        }
    }
}