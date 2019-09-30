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
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;


        //Constructor(Spawner)

        public Receipe()
        {
            amountOfLemons = 0;
            amountOfSugarCubes = 0;
            amountOfIceCubes = 0;
            pricePerCup = 0;
        
        
        
        
        
        
        
        }




        //Member Methods (Can Do)

        public void MakingLemonade()
        {
            
            LemonsIntoLemonade();
            AddingSuger();
            SelectIce();
            PricePerCup();
        }        
     
         private void LemonsIntoLemonade()
        {
            Console.WriteLine("Please enter how many Lemons you would like to add");
            amountOfLemons = Int32.Parse (Console.ReadLine());
            
        }

        private void AddingSuger()
        {
            Console.WriteLine("Please enter how many cups of Sugar you would like to add");
            amountOfSugarCubes = Int32.Parse(Console.ReadLine());
            
        }
        

        private void SelectIce()
        {
            Console.WriteLine("Please enter the amount of Ice Cubes you would like to add");
             amountOfIceCubes = Int32.Parse(Console.ReadLine());
            


        }


        private void PricePerCup()
        {
            Console.WriteLine("In cents How much would you like to charge per cup?");
            pricePerCup =double.Parse(Console.ReadLine());
        
        }   
    
    
    
    }



}
