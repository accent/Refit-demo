using System;
using System.Linq;
using System.Threading.Tasks;

namespace RefitDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            RestServiceClient client = new RestServiceClient();
            Console.WriteLine("Item list");
            var newsList = await client.GetNewsList(1);
            foreach (var news in newsList)
            {
                Console.WriteLine($"{news.Id} - {news.Title}");
            }

            Console.WriteLine("Single item");
            var item = await client.GetItem(newsList.First().Id);
            Console.WriteLine($"{item.Id} - {item.Title}");

            Console.ReadLine();
        }
    }
}
