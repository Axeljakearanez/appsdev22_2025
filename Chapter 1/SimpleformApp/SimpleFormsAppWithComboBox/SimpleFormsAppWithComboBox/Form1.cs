namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            comboBoxCuisine.Items.Add("Italian");
            comboBoxCuisine.Items.Add("Mexican");
            comboBoxCuisine.Items.Add("Japanese");
            comboBoxCuisine.Items.Add("Philippines");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            checkedListBoxFood.Items.Clear(); // Clear previous items

            if (comboBoxCuisine.SelectedItem != null)
            {
                string selectedCuisine = comboBoxCuisine.SelectedItem.ToString();

                // Add food items based on selected cuisine
                if (selectedCuisine == "Italian")
                {
                    checkedListBoxFood.Items.Add("Pizza");
                    checkedListBoxFood.Items.Add("Pasta");
                    checkedListBoxFood.Items.Add("Lasagna");
                    checkedListBoxFood.Items.Add("Tiramisu");
                }
                else if (selectedCuisine == "Mexican")
                {
                    checkedListBoxFood.Items.Add("Tacos");
                    checkedListBoxFood.Items.Add("Burrito");
                    checkedListBoxFood.Items.Add("Quesadilla");
                    checkedListBoxFood.Items.Add("Churros");
                }
                else if (selectedCuisine == "Japanese")
                {
                    checkedListBoxFood.Items.Add("Sushi");
                    checkedListBoxFood.Items.Add("Ramen");
                    checkedListBoxFood.Items.Add("Tempura");
                    checkedListBoxFood.Items.Add("Mochi");
                }
                else if (selectedCuisine == "Philippines")
                {
                    checkedListBoxFood.Items.Add("Lumpia");
                    checkedListBoxFood.Items.Add("Balut");
                    checkedListBoxFood.Items.Add("Adobo");
                    checkedListBoxFood.Items.Add("Sinigang");
                }
            }
            else
            {
                MessageBox.Show("Please select a cuisine first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBoxFood.CheckedItems)
            {
                if (!listBoxFavorites.Items.Contains(item)) // Avoid duplicates
                {
                    listBoxFavorites.Items.Add(item);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            while (listBoxFavorites.SelectedItems.Count > 0)
            {
                listBoxFavorites.Items.Remove(listBoxFavorites.SelectedItem);
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listBoxFavorites.Items.Clear();
        }
    }
}
