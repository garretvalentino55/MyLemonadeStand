using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables 
        string condition;
        List<string> weatherConditions;
        int temperature;
        //constructor 
        public Weather()
        {
            weatherConditions = new List<string>();
            AddWeather();
        }
        // member methods
        private void AddWeather()
        {
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Rainy");
        }
        public int WeatherTemperature(Random random) // single responsibility
        {
            random.Next(50,100);
            int temperature = random.Next(50, 100);
            return temperature;
        }
        public string DecideWeather(Random random)
        {
            dailyWeather = random.Next(1, 3);
            condition = weatherConditions[dailyWeather];
            return condition;
        }

    }
}
