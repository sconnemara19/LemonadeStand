using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    static class Userinterface
    {

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

       

        public static void DisplayStoreMenu()
        {
            Console.WriteLine("Welcome to the store!\n1)View Inventory\n2)Buy Lemons .50cents/per Lemon\n3)Buy Sugar Cubes $1.50\n4)Buy IceCubes/\n5)Buy Cups");
        }
        public static int GetIntegerInput()
        {
            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                return choice;

            }
            catch
            {
                Console.WriteLine("Invaild entry, please try again");
                return GetIntegerInput();
            }

        }
        public static void DisplayInventory(Inventory inventory)
        {
            Console.WriteLine("Inventory\nLemons: " + inventory.lemons.Count);
            Console.WriteLine("Inventory\nSugarCubes: " + inventory.sugarCubes.Count);
            Console.WriteLine("Inventory\nIceCubes: " + inventory.iceCubes.Count);
            Console.WriteLine("Inventory\nCups:" + inventory.cups.Count);


        }
        public static void PurchasingLemons()
        {
            Console.WriteLine("How many lemons would you like to buy?");
        }


        


       
    }
}
