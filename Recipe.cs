using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    public class Recipe
    {
        //member variables
        public int numberofLemons;
        public int numberofSugarCubes;
        public int numberOfIceCubes;
        public double pricePerCup;

        //constructor
        public Recipe()
        {
            numberofLemons = 4;
            numberofSugarCubes = 4;
            numberOfIceCubes = 4;
            pricePerCup = .50;
            
        }

        //member methods
        public void SetRecipe()
        {
            Console.WriteLine("How Many Lemons Would You Like To Add ");
            numberofLemons = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How Many Sugar Cubes Would You Like To Add ");
            numberofSugarCubes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How Many Ice Cubes Would You Like To Add" );
            numberOfIceCubes = Convert.ToInt32(Console.ReadLine());

        }
        public void SetPrice()
        {
            Console.WriteLine("what Would You Like To Charge Your Customers For Each Cup Of Lemonade");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
        }


    }
}
