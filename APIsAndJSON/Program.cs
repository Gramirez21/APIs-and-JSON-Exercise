using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System;
namespace APIsAndJSON
{
    public class Program
    {
        

        public static void Kanye()
        {
            var client = new HttpClient();

            var ye = "https://api.kanye.rest/";

            var yeAnswer = client.GetStringAsync(ye).Result;

            var yeGold = JObject.Parse(yeAnswer).GetValue("quote").ToString();

            Console.WriteLine(yeGold);
        }

        public static void Ron() 
        {
            var client = new HttpClient();

            var swonson = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var swonsonAnswer = client.GetStringAsync(swonson).Result;
            var swonsonQuote = JArray.Parse(swonsonAnswer).First().ToString();

            Console.WriteLine(swonsonQuote);

        }

        public static void Main(string[] args)
        {

            Weatherapp.Weather();
         

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ron:"); Ron();
                Console.WriteLine();
                Console.WriteLine("Ye");  Kanye();
                Console.WriteLine();
            }

            
            

          
            

            
            

            

            

        }
    }
}
