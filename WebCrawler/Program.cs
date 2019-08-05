using System;
using System.Linq;
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

            Console.ReadLine();
        }

        private static async Task StartCrawlerAsync()
        {
            var urlMain = "https://www.norwegian.com/en/";
            var url =
                "https://www.norwegian.com/en/start/booking/farecalendar/?A_City=RIX&AdultCount=1&ChildCount=0&CurrencyCode=EUR&D_City=OSL&D_Day=01&D_Month=201909&D_SelectedDay=01&IncludeTransit=true&InfantCount=0&R_Day=05&R_Month=201908&TripType=1";

            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            Console.WriteLine(html);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);

            var table = htmlDocument.DocumentNode.Descendants("table").Where(node =>
                node.GetAttributeValue("class", "").Equals("lowfare-calendar__table")).ToList();

//            foreach (var t in table)
//            {
//                Console.WriteLine(t.Descendants("tr").Where(node => node.GetAttributeValue("class","").Equals("lowfare-calendar__row lowfare-calendar__row--animate")));    
//            }
        }
    }
}
