using System.Net.Http.Json;

namespace WalutaLol
{
    public partial class Form1 : Form
    {
        private Dictionary<string, double> currencies = new();

        public Form1()
        {
            InitializeComponent();

            var http = new HttpClient() {
                BaseAddress = new Uri("https://api.nbp.pl/")
            };

            var response = http.GetFromJsonAsync<List<Table>>("/api/exchangerates/tables/A?format=json/").Result;

            foreach(var currency in response[0].rates)
            {
                currencies.Add(currency.code, currency.mid);
            }

            foreach (var currency in currencies.Keys)
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
