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
                    //Buy Lemons
                    
                    break;
            }

            
        
        
        
        
        
        
        } 

        public void BuyLemons()
        {
            Userinterface.PurchasingLemons();
            if( player.wallet )
            {

            }
        }
        


    }
}
