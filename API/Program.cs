
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;

namespace API
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DB())
            {
                Console.WriteLine("Baza danych uruchomiona.");
            }

            CurrencyApiClient api = new CurrencyApiClient();
            var task = api.GetExchangeRatesAsync();
            task.Wait();
            var data = task.Result;

            Console.WriteLine($"Kursy walut (bazowe: USD) na dzien: {api.date}:");

            var currencies = data.rates.Select(rate => new Currency
            {
                Name = rate.Key,
                Value = rate.Value,
                Date = api.date
            }).ToList();

            using (var context = new DB())
            {
                context.Currencies.AddRange(currencies);
                context.SaveChanges();
            }

            foreach (var rate in data.rates)
            {
                Console.WriteLine($"{rate.Key}: {rate.Value}");
            }

            Console.WriteLine("Dane zostały dodane do bazy.");
        }
    }
}
