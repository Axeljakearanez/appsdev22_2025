namespace SimpleFormsAppWithMessageBoxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string middleName = textBox2.Text;
            string lastName = textBox3.Text;
            string suffix = textBox4.Text;


            DialogResult result = MessageBox.Show("Are you sure you want to submit this information?",
                                                  "Confirm Submission",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);


            if (result == DialogResult.Yes)
            {

                MessageBox.Show("Information submitted successfully!", "Submission Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Show the greeting message

            }
            else
            {

                MessageBox.Show("Submission canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
