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

        // member methods

        public int WeatherTemperature(Random random) // single responsibility
        {
            random.Next(50,100);
           int temperature = random.Next(50, 100);
            return temperature;
        }
        public string 

    }
}
