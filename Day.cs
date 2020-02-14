using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //member variables
        string weather;
        int day;
        int nextDay;

        
        //constructor

        //member methods
        public int ChangeDay()
        {
            int firstDay = 0;
            Console.WriteLine("Good Luck");
            if (firstDay >= 7)
            {
                nextDay++;
                Console.WriteLine("Day" + nextDay);

            }
            return nextDay;
            
            
        }
    }
}
