using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tinkoff.Trading.OpenApi.Models;
using Tinkoff.Trading.OpenApi.Network;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Linq;

namespace tinkoff_invest_analytics
{
    public partial class MainWindow : Form
    {
        static readonly string token = Environment.GetEnvironmentVariable("TINKOFF_TOKEN");
        static readonly Connection connection = ConnectionFactory.GetConnection(token);
        static readonly Context context = connection.Context;

        public MainWindow()
        {
            InitializeComponent();
            if (!System.IO.File.Exists("figi_name.json"))
                Serialize_figi_name_stocks_json();
        }

        private static async void Serialize_figi_name_stocks_json()
        {
            var market_stocks = await context.MarketStocksAsync();
            int count = market_stocks.Total;
            int i = 0;

            string[] name = new string[count];
            string[] figi = new string[count];

            foreach (MarketInstrument instrument in market_stocks.Instruments)
            {
                name[i] = instrument.Name;
                figi[i] = instrument.Figi;
                i++;
            }

            var market = new Market
            {
                Figi = figi,
                Name = name
            };

            var json = JsonConvert.SerializeObject(market, Formatting.Indented);
            File.WriteAllText(@"figi_name.json", json);
        }

        private Dictionary<string, string> Deserialaze_figi_name_json()
        {
            Dictionary<string, string> figi_name = new Dictionary<string, string>();
            string json = File.ReadAllText("figi_name.json");

            Market deserialized_market = JsonConvert.DeserializeObject<Market>(json);
            for (int i = 0; i < deserialized_market.Figi.Length; i++)
            {
                figi_name.Add(deserialized_market.Figi[i], deserialized_market.Name[i]);
            }

            return figi_name;
        }

        private async void Button_operation_get_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker_from.Value;
            DateTime to = dateTimePicker_to.Value;
            List<Operation> operations = new List<Operation>();

            try
            {
                operations = await context.OperationsAsync(from, to, "");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Fill_grid(operations);
            Sum_margin_commission();
        }

        private string Get_company_name_by_figi(string figi)
        {
            var figi_name_dict = Deserialaze_figi_name_json();
            string value = figi_name_dict.FirstOrDefault(d => d.Key.Contains(figi)).Value;

            return value;
        }

        private async void Button_get_all_operations_Click(object sender, EventArgs e)
        {
            DateTime account_started_at = DateTime.Parse(Environment.GetEnvironmentVariable("TINKOFF_ACCOUNT_STARTED"));
            DateTime cur_date = DateTime.Now;
            List<Operation> operations = new List<Operation>();

            try
            {
                operations = await context.OperationsAsync(account_started_at, cur_date, "");
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }

            Fill_grid(operations);
            Sum_margin_commission();
        }

        private void Fill_grid(List<Operation> operations)
        {
            /// <summary>
            /// Заполняет таблицу совершенных операций
            /// </summary>
            dataGridView_operations.Rows.Clear();
            string sum, operation_type, price, quantity, currency, date;
            string company_name = "";
            int id = 0;

            foreach (Operation operation in operations)
            {
                id += 1;

                string figi = operation.Figi;

                operation_type = operation.OperationType.ToString();
                sum = operation.Payment.ToString();
                price = operation.Price.ToString();
                quantity = operation.Quantity.ToString();
                currency = operation.Currency.ToString();
                date = operation.Date.ToString();
                if (figi != null)
                {
                    company_name = Get_company_name_by_figi(figi);
                }
                if (sum != "0")
                    dataGridView_operations.Rows.Add(id, company_name, price, quantity, operation_type, sum, currency, date);
                company_name = "";
            }
        }

        private void Sum_margin_commission()
        {
            double payment = 0;
            for (int i = 0; i < dataGridView_operations.Rows.Count; i++)
            {
                var operation_type = dataGridView_operations.Rows[i].Cells["operation_type"].Value;
                if ((string)operation_type == "MarginCommission")
                    payment -= Convert.ToDouble(dataGridView_operations.Rows[i].Cells["payment"].Value);
            }
            textBox_margin_commission.Text = payment.ToString() + " рублей";
        }
    }
}
