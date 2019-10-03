using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Weather
    {


        // Member Variables

        string condition;
        public int temperature;
        private List<string> weatherConditions;
        public string predictedForecast;
        Random rand = new Random();
        //Constructor (Spawner)

        public Weather()
        {

            temperature = 0;
            weatherConditions = new List<string>() { "Sunny, Cloudy, Rainy, Windy" };
            predictedForecast = null;
         }

        public void ChoosingWeather()
        {
            int index = rand.Next(3);
            Console.WriteLine(weatherConditions[index]);

        }


    }
}

    




    
