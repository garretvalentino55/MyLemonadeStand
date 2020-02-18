using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variables 
        Day currentDay;
        Random random;

        // constructor 
        public Game()
        {
            random = new Random();
            currentDay = new Day(random);
        }
        // member methods 
        public void RunGame()
        {
            //1 Display Rules
            UserInterface.DisplayRules();
            ChooseGameMode();
            DisplayWeather();
            BuyIngredientsFromTheStore();
            DisplayInventory();
            MakeRecipe();
            SetPrice();
            RunDay();
            DisplayDailyResults();
            
        }
        public void ChooseGameMode()
        {
            Console.WriteLine("How Many Days Would You Like To Play For");
            Console.WriteLine("If You Would Like To Play For 7 Days Press 1");
            Console.ReadKey();
        }
        public void DisplayWeather()
        {
            Console.WriteLine("The Forcast For Today Is " + currentDay.weather.condition + "And The Temperature Is " + currentDay.weather.temperature);
        }
        public string BuyIngredientsFromTheStore()
        {

        }
        public string DisplayInventory()
        {

        }
        public string MakeRecipe()
        {

        }
        public int SetPrice()
        {

        }
        public Day RunDay()
        {

        }
        public string DisplayDailyResults()
        {

        }
    }
}
