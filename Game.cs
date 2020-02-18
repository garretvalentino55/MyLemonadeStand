﻿using System;
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
        Store store;
        Player player;
        // constructor 
        public Game()
        {
            store = new Store();
            random = new Random();
            currentDay = new Day(random);
            player = new Player();
            recipe = new Recipe();
        }
        // member methods 
        public void RunGame()
        {
            
            UserInterface.DisplayRules();
            ChooseGameMode();
            DisplayWeather();
            BuyIngredientsFromTheStore();
            DisplayInventory();
            ChooseRecipe();
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
        public void BuyIngredientsFromTheStore()
        {
            store.SellCups(player);
            store.SellIceCubes(player);
            store.SellLemons(player);
            store.SellSugarCubes(player);
            UserInterface.DisplayInventory(player);
            Console.WriteLine();
        }

        public void ChooseRecipe()
        {
           Recipe.
        }
        public void SetPrice()
        {

        }
        public Day RunDay()
        {

        }
        public void DisplayDailyResults()
        {

        }
    }
}
