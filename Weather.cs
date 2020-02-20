using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Weather
    {
        //member variables 
       public  string condition;
        List<string> weatherConditions;
       public int temperature;
        //constructor 
        public Weather(Random random)
        {
            weatherConditions = new List<string>();
            AddWeather();
            SetWeatherTemperature(random);
            DecideWeather(random);

        }
        // member methods
        private void AddWeather()
        {
            weatherConditions.Add("Sunny");
            weatherConditions.Add("Cloudy");
            weatherConditions.Add("Rainy");
            
        }
        public void SetWeatherTemperature(Random random) // single responsibility because the only thing this is doing is choosing a weather temperature
        {
           
            temperature = random.Next(50, 102);
            
        }
        public void DecideWeather(Random random)// open closed principle becasue you can add weather conditions to the list but the code for decide weather doenst have to be changed 
        {
            int chosenCondition = random.Next(0, weatherConditions.Count);
            condition = weatherConditions[chosenCondition];
        }

    }
}
