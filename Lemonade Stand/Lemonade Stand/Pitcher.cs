using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Pitcher
    {
        // Pass recipe and inventory into this class
        Receipe receipe;
        Inventory inventory;
        int cupsInPitcher;
        // Have a create recipe method
        // If the player has enough inventory
        // Take away that amount of inventory based on how many they set to use on the recipe
        //Member Variable (Has A)




        //Constructor (Spawner)
        public Pitcher(Receipe passinginreceipe, Inventory passingininventory)
        {
            receipe = passinginreceipe;
            inventory = passingininventory;
            cupsInPitcher = 8;
            

        }

         
       






        //Member Methods (Can Do)
        public void CreateReciepe()
        {
            if(inventory.lemons.Count >= receipe.amountOfLemons && inventory.sugarCubes.Count >= receipe.amountOfSugar && inventory.iceCubes.Count >= receipe.amountOfIceCubes && inventory.cups.Count >= cupsInPitcher )
            {
                inventory.lemons.RemoveRange(0, receipe.amountOfLemons);
                inventory.sugarCubes.RemoveRange(0, receipe.amountOfSugar);
                inventory.iceCubes.RemoveRange(0, receipe.amountOfIceCubes);
                inventory.cups.RemoveRange(0, cupsInPitcher);
                
            }
        }

    
    
    }



}
