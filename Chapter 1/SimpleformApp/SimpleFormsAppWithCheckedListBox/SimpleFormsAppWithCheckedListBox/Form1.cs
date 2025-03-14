using System.Windows.Forms;

namespace SimpleFormsAppWithCheckedListBox
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            string[] movies = { "Wrong Turn", "Conjuring", "IT", "Smile", "Insidious" };
            checkedListbox.Items.AddRange(movies);
            checkedListbox.CheckOnClick = true;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 0)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListbox.Items)
            {
                bool isSelected = checkedListbox.GetItemChecked(checkedListbox.Items.IndexOf(item));
                if (isSelected && !listBox.Items.Contains(item))
                {
                    listBox.Items.Add(item);
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
