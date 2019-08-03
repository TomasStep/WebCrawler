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
        }

        private static async Task StartCrawlerAsync()
        {
            var url = "https://www.norwegian.com/en/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument(); // to understand html content correctly
            htmlDocument.LoadHtml(html);
        }
    }
}
