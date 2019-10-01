using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
   public static class Userinterface
    {
        //Member Variables 
       


        //Constructor
        static Userinterface()
        {
           
        }


        //Member Methods

        public static void DisplayRules()
        {
            Console.WriteLine("Welcome To Lemonade Stand");
            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.\n: Start with the basic recipe, but try to vary the recipe and see if you can do better.\n: Lastly, set your price and sell your lemonade at the stand\n: Try changing up the price based on the weather conditions as well");
            Console.WriteLine("At the end of the game you'll see how much money you made\n: Write it down and play again to try and beat your score!");

        }

        public static void DisplayStore()
        {
            Console.WriteLine();
        }
    }
}
