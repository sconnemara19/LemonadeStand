using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Store
    {
        //Member Variables 

        Player player;
        double priceOfLemons;
        double priceOfSugarCubes;
        double priceOfIceCubes;
        double priceOfCups;
        
      
       
        
        

        //Constuctor(Spawner)

        public Store(Player playerPassingIn)
        {

            // pass player into store
            player = playerPassingIn;

            priceOfLemons = .50;
            priceOfSugarCubes = 1.50;
            priceOfIceCubes = 1.00;
            priceOfCups = .75;

        
        } 


        public void Menu()
        {
            Userinterface.DisplayStoreMenu();
            int choice = Userinterface.GetIntegerInput();
            switch (choice)
            {
                case 1:
                    Userinterface.DisplayInventory(player.inventory);

                    break;
                case 2:
                    BuyLemons();
                    
                    break

            }

            
        
        
        
        
        
        
        } 

        public void BuyLemons()
        {
            int amount = Userinterface.PurchasingLemons();
            // check wallet to see if user has enough money to buy this amount of lemons
            if (player.wallet.moneyInWallet >= priceOfLemons)
            {
                for (int i = 0; i <= amount; i++)
                {
                    player.inventory.lemons.Add(new Lemon());
                }
                Console.WriteLine("success in buying lemons");
            }
            else 
            {
                Console.WriteLine("You need more money");
            }
            
           
            
        }
        

        public void BuySugarCubes()
        {
            int amount = Userinterface.PurchasingSugarCubes();

            for (int i = 0; i <= amount; i++)
            {
                player.inventory.sugarCubes.Add(new SugarCube());
            }

        }

        public void BuyIceCubes()
        {
            int amount = Userinterface.PurchashingIceCubes();

            for (int i = 0; i <= amount; i++)
            {
                player.inventory.iceCubes.Add(new IceCube());

            }
        }
    
        public void BuyCups()
        {
            int amount = Userinterface.PurchasingCups();

            for (int i = 0; i <= amount; i++)
            {
                player.inventory.cups.Add(new Cup());
            }
        }    
    
    
    
    }

}
