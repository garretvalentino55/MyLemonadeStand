using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Pitcher pitcher;
        public Recipe seceretRecipe;
        string name;
        int cupsLeftInPitcher;



        // constructor (SPAWNER)
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
        }

        // member methods (CAN DO)
        public string RefillPitcher()
        {
            int WhenSold()
            {
                if (cupsLeftInPitcher > 0)
                {
                    for (int i = 10; i > 0; --i)
                    {
                        Console.WriteLine(i + " cups are left");
                        return i;
                    }
                }
                else
                {
                    cupsLeftInPitcher = 0;
                    Pitcher pitcher = new Pitcher();
                    Convert.ToInt32.pitcher= new Pitcher();
                    return pitcher;
                }


            }

        }
        public int BuyFromStore()
        {
            
        }
        public string MakeSeceretRecipe()
        {

        }


    }
}
