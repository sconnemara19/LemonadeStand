using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Receipe
    {
        //Member Variables (Has A)
        public int amountOfLemons;
        public int amountOfSugar;
        public int amountOfIceCubes;
        public double pricePerCup;

        Inventory inventory;
        Pitcher pitcher;
        
        //Constructor(Spawner)

        public Receipe()
        {
            amountOfLemons = 0;
            amountOfSugar = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0;
        }




        //Member Methods (Can Do)

        public void SetRecipe()
        {

            SetLemonsOnRecipe();
            SetSugarCubesOnRecipe();
            SetIceOnRecipe();
            SetPricePerCupOnRecipe();
            
        }        
     
         private void SetLemonsOnRecipe()
        {
            Console.WriteLine("Please enter how many Lemons you would like to use per pitcher?");
            amountOfLemons = Int32.Parse (Console.ReadLine());
            
        }

        private void SetSugarCubesOnRecipe()
        {
            Console.WriteLine("Please enter how many cups of Sugar you would like to use per pitcher?");
            amountOfSugar = Int32.Parse(Console.ReadLine());
            
        }
        

        private void SetIceOnRecipe()
        {
            Console.WriteLine("Please enter the amount of Ice Cubes you would like to use per pitcher?");
             amountOfIceCubes = Int32.Parse(Console.ReadLine());
            


        }


        private void SetPricePerCupOnRecipe()
        {
            Console.WriteLine(" How many cups would you like to charge per cup?");
            pricePerCup =double.Parse(Console.ReadLine());
        
        }
        
            
    
    }



}
