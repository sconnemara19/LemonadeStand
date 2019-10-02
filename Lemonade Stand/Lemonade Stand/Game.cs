using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade_Stand
{
    class Game
    {

        //Member Variables (Has A)

        Player player = new Player();
        
        List<Day> days;
        int currentDay;





        //Constructor (Spawner)

        public Game()
        {
             
            

        }



        //Member Methods

        public void RunGame()
        {
            Userinterface.DisplayRules();
            player.EnterName();
            Store store = new Store(player);
            store.Menu();
        }

        
       
    
    
    
    
    
    }





}
