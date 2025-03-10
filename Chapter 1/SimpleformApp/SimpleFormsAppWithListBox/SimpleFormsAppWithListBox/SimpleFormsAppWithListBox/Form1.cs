namespace SimpleFormsAppWithListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstbox.Items.Remove(lstbox.Text);
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !lstbox.Items.Contains(textBox1.Text))
            {

                lstbox.Items.Add(textBox1.Text);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
        }
    }
}
