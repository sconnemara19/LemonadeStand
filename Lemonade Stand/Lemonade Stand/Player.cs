using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Player
    {
        //Member Variables (Has A)
        public string name;
        public Inventory inventory = new Inventory();
        public Wallet wallet = new Wallet();

        public Receipe receipe = new Receipe();
        public Pitcher pitcher;
        public double buisnessProfits;

        






        //Constructor (Spawner)

        public Player()
        {
            name = null;

            
        
        
        
        
        
        }
    
    

     //Member Methods (Can Do)   


        public void EnterName()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
    }
}
