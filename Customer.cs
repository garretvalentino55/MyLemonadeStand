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
        string name;
        public int money;
        
        //constructor
        Customer customer = new Customer();
        

        //member methods
        public int BuyLemonade()
        {
            int chanceToBuyLemonade = random.Next(1, 100);
            if (chanceToBuyLemonade >= 50)
            {
                money = 10;
                int payForLemonade = money -= int costOfLemonade;
                return costOfLemonade;
                
            }

        }



    }
}
