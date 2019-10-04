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
        Random rng = new Random();
        //Constructor (Spawner)

        public Weather()
        {

            
            weatherConditions = new List<string>() { "Sunny", "Cloudy", "Rainy", "Windy" };
            predictedForecast = null;
         }

        public void ChoosingWeather()
        {
            int index = rand.Next(weatherConditions.Count);
            condition = weatherConditions[index];
            Userinterface.DisplayRandomConditions(condition);


        }
        public void ChoosingTemperature()
        {

            int result = rng.Next(50,100);
            temperature = result;
            Userinterface.DisplayRandomTemperature(temperature);
            
            
        }

        public void PredictedWeather()
        {

        }

    }
}

    




    
