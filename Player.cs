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
        public void FillPitcher()
        {
            pitcher = new Pitcher();
        }

        public void CheckInventory()
        {
            if(pitcher.cupsLeftInPitcher == 0)
            {
                FillPitcher();
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
