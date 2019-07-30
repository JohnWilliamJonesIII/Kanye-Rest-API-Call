using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Mark8InClassExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = " https://api.kanye.rest";
            HttpClient client = new HttpClient();
            string response = client.GetStringAsync(url).Result;

            int quoteStartIndex = response.IndexOf("value") + 8;
            int quoteLength = response.Length - quoteStartIndex - 1;
            string kanyeQuote = response.Substring(quoteStartIndex, quoteLength);
            Console.WriteLine("From the mind of Kanye West" + kanyeQuote + '.');
        }
    }
}
