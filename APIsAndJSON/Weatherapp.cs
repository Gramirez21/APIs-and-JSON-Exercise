using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    
   
    public class Weatherapp
    {

        public static void Weather()
        {
            var client = new HttpClient();

            
            string APIKey = "25b96530559420a386fde31ccde0dfeb";

            Console.WriteLine("Please enter city name");
            var cityName = Console.ReadLine();


            string apiCall = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKey}&units=imperial";

            


            var response = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(response)["main"]["temp"].ToString());

            Console.WriteLine($"The Tempature in {cityName} is {temp}");

        }
    }
}
