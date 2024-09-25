using System.Net.Http.Json;
using System.Runtime.ConstrainedExecution;
using static System.Net.WebRequestMethods;

namespace WalutaLol
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Rate> currencies = new();

        public Form1()
        {
            InitializeComponent();

            var http = new HttpClient() {
                BaseAddress = new Uri("https://api.nbp.pl/")
            };

            currencies.Add("PLN", new("Z³oty", "PLN", 1));
            fillCurrencies(http, 'A');
            fillCurrencies(http, 'B');

            foreach (var currency in currencies)
            {
                inputCurrency.Items.Add(currency.Value.code);
                outputCurrency.Items.Add(currency.Value.code);
            }
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            if (!currencies.ContainsKey(inputCurrency.Text) || !currencies.ContainsKey(outputCurrency.Text))
            {
                MessageBox.Show("Wpisz poprawne wartosci downie");
                return;
            }

            var inputMultiplier = currencies[inputCurrency.Text].mid;
            var outputMultiplier = currencies[outputCurrency.Text].mid;

            var inputNumber = double.Parse(inputValue.Text);
            var commonValue = inputNumber * inputMultiplier;
            var result = commonValue * (1 / outputMultiplier);
            outputValue.Text = result.ToString("0.00");
        }

        private void fillCurrencies(HttpClient httpClient, char table)
        {
            var response = httpClient.GetFromJsonAsync<List<Table>>($"/api/exchangerates/tables/{table}?format=json/").Result;
            foreach(var currency in response[0].rates)
            {
                currencies.Add(currency.code, currency);
            }
        }
    }
}
