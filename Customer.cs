using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variables
        List<string> names;
        int temperaturePreference;
        double pricePreference;
        public double money;
        
        //constructor
        public Customer()
        {
            List<string> names = new List<string>();
            names.Add("Mary");
            names.Add("James");
            names.Add("Beth");
            names.Add("Sue");
            names.Add("Frank");
            names.Add("Jeff");
            names.Add("Tony");
            names.Add("Kyle");
            names.Add("Luke");
            names.Add("Lori");
            names.Add("Betty");
            names.Add("Carl");
        }
        public void SetPref(Random random)
        {
            temperaturePreference = random.Next(50, 105);
            pricePreference = random.NextDouble() * 1;
            foreach(string name in names)
            {

            }

        }
        //member methods
        public bool BuyLemonade(Recipe recipe, Weather weather)
        {
            
            if(weather.temperature > temperaturePreference && pricePreference > recipe.pricePerCup)
            {
                return true;
            }
        }



    }
}
