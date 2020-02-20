using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Day
    {
        //member variables
        public Weather weather;
        int day;
        int nextDay;
        List<Customer> customers;
        public Customer customer;
        public Recipe recipe;
        //constructor
        public Day(Random random)
        {
            weather = new Weather(random);
            customers = new List<Customer>();

        }


        //member methods
     
        public void CreateCustomer(Random random)
        {
            
            for (int i =0; i < 100; i ++)
            {
                Customer customer = new Customer(random);
                customers.Add(customer);
            }

        }

        public void SellLemonade(Player player)
        {
            foreach (Customer customer in customers)
            {
                customer.BuyLemonade (player.seceretRecipe, weather);
            }
        }
        public void DisplayWeather()
        {
            Console.WriteLine("The Forcast For Today Is " + weather.condition + "And The Temperature Is " + weather.temperature);
        }
        public void RunDay(Random random, Player player)
        {

            Console.WriteLine("Good Luck");
            //display weather
            //go to store
            //set recipe
            //sell lemonade
            DisplayWeather();
            CreateCustomer(random);
            SellLemonade(player);
            nextDay++;
            Console.WriteLine("Day" + nextDay);


        }

    }
}
