namespace MessageBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box.", "Title", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box.", "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box.", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box.", "Title", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a message box.", "Title", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
