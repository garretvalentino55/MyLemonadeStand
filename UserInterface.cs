using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    static class UserInterface
    {
        public static void DisplayRules()
        {
            Console.WriteLine("                                                                                                                                  ");
            Console.WriteLine("                                                                                                                                  ");
            Console.WriteLine("                                                    Welcome To The Lemonade Stand Game                                            ");
            Console.WriteLine("                                                                                                                                  ");
            Console.WriteLine("                                                                                                                                  ");
            Console.WriteLine("                                                                                                                                  ");
            Console.WriteLine("                         The Object Of This Game Is To Make The Best Lemonade And Make The Most Money Possible                    ");
            Console.WriteLine("                                       You Will Have To Make Some Choices That Will Effect The Game Play                          ");
            Console.WriteLine("                             There Will Be Factors That You Need To Account For These Things Will Include things like             ");
            Console.WriteLine("                   Weather Conditions If The Weather Is Bad You Will Need To Adjust Your Price Accordingly                        ");
            Console.WriteLine("    The Weather Will Not Only Effect The Price You Should Sell For But Also How Many Opportunities You will Have to Make Money    ");
            Console.WriteLine("       You Will Also Need To Worry About Money You Will Start Off With 20 Dollars But You Will Need To Buy The Ingredients        ");
            Console.WriteLine("                                          If You Run Out Of Money You Wont Be Able To Play Anymore                                ");
            Console.WriteLine("         Also If You Run Out Of Money You Wont Be Able To Sell The Rest Of The Day So It Is Important to Check Your Inventory     ");
            Console.ReadLine();
        }

        public static int GetNumberOfItems(string itemsToGet)
        {
            bool userInputIsAnInteger = false;
            int quantityOfItem = -1;

            while (!userInputIsAnInteger || quantityOfItem < 0)
            {
                Console.WriteLine("How many " + itemsToGet + " would you like to buy?");
                Console.WriteLine("Please enter a positive integer (or 0 to cancel):");

                userInputIsAnInteger = Int32.TryParse(Console.ReadLine(), out quantityOfItem);
            }

            return quantityOfItem;
        }
    }
}
