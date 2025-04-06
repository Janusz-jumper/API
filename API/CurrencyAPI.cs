using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace API
{
    public class CurrencyApiClient
    {
        private HttpClient client = new HttpClient();
        public string date;

        public async Task<ExchangeRates> GetExchangeRatesAsync()
        {
            Console.WriteLine("Podaj date w formacie YYYY-MM-DD:");
            date = Console.ReadLine();
            string call = $"https://openexchangerates.org/api/historical/{date}.json?app_id=824b445e62274ae9998ce5e590f69bae";
            string response = await client.GetStringAsync(call);
            ExchangeRates data = JsonSerializer.Deserialize<ExchangeRates>(response);
            return data;
        }
    }

}
