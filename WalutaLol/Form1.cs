namespace WalutaLol
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> currencies = new();

        public Form1()
        {
            InitializeComponent();
            currencies.Add("PLN", 1.0f);
            currencies.Add("USD", 3.81f);
            currencies.Add("EUR", 4.26f);
            currencies.Add("RUB", 0.041f);
            currencies.Add("BAT", 0.12f);

            foreach(var currency in currencies.Keys)
            {
                inputCurrency.Items.Add(currency);
                outputCurrency.Items.Add(currency);
            }
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            if (!currencies.ContainsKey(inputCurrency.Text) || !currencies.ContainsKey(outputCurrency.Text))
            {
                MessageBox.Show("Wpisz poprawne wartosci downie");
                return;
            }

            var inputMultiplier = currencies[inputCurrency.Text];
            var outputMultiplier = currencies[outputCurrency.Text];

            var inputNumber = double.Parse(inputValue.Text);
            var commonValue = inputNumber * inputMultiplier;
            var result = commonValue * (1 / outputMultiplier);
            outputValue.Text = result.ToString("0.00");
        }
    }
}
