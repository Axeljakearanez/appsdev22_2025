namespace Simple_Iphone_loan_app
{
    public partial class Form1 : Form
    {
        private string[] iPhoneModels = {
            "iPhone 16 Pro Max (256GB)",
            "iPhone 16 Pro (128GB)",
            "iPhone 16 Plus (128GB)",
            "iPhone 16 (128GB)",
            "iPhone 16e (128GB)"
        };
        private decimal[] iPhonePrices = { 69990, 84990, 79990, 74990, 68990 };

        private string[] loanTerms = { "12 Months", "24 Months", "30 Months", "36 Months" };
        private decimal[] interestRates = { 0.05m, 0.10m, 0.125m, 0.15m };

        private string[] addOns = { "Apple Care Plus", "USB-C Charging Adapter", "MagSafe Charger (1M)" };
        private decimal[] addOnPrices = { 2590, 1990, 2490 };

        public Form1()
        {
            InitializeComponent();
            PopulateControls();
        }
        private void PopulateControls()
        {
            listBox1.Items.AddRange(iPhoneModels);
            checkedListBox1.Items.AddRange(addOns);
            comboBox1.Items.AddRange(loanTerms);
            listBox1.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int modelIndex = listBox1.SelectedIndex;
            int termIndex = comboBox1.SelectedIndex;

            if (modelIndex < 0 || termIndex <0 )
            {
                MessageBox.Show("Please select and iphone item to loan.");
                return;
            }
            decimal principalAmount = iPhonePrices[modelIndex];
            decimal interestRate = interestRates[termIndex];

            decimal addOnsCost = 0;
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    addOnsCost += addOnPrices[i];
                }
            }
            decimal totalLoanAmount = principalAmount + addOnsCost;
            decimal downPayment = totalLoanAmount * 0.10m;
            decimal interestAmount = totalLoanAmount * interestRate;
            decimal totalAmountPayable = totalLoanAmount + interestAmount;
            decimal monthlyAmortization = totalAmountPayable / (12 * (termIndex + 1));

        }
    }
}
       
