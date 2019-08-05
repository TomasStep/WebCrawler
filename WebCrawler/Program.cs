using System;
using System.Net.Http;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace WebCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            StartCrawlerAsync();

            Console.Read();
            Console.ReadLine();
        }

        private static async Task StartCrawlerAsync()
        {
            var url = "https://www.norwegian.com/en/";
            var urlMain = "https://www.norwegian.com/en/";
            var url =
                "https://www.norwegian.com/en/start/booking/farecalendar/?A_City=RIX&AdultCount=1&ChildCount=0&CurrencyCode=EUR&D_City=OSL&D_Day=01&D_Month=201909&D_SelectedDay=01&IncludeTransit=true&InfantCount=0&R_Day=05&R_Month=201908&TripType=1";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument(); // to understand html content correctly
            htmlDocument.LoadHtml(html);
        }
    }
}
