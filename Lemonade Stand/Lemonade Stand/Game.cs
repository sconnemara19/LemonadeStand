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
            GameMenu();




        }


        public void GameMenu()
        {
            Userinterface.DisplayGameMenu();
            int menu = Userinterface.DisplayInput();
            switch (menu)
            {
                case 1:
                    Store store = new Store(player);
                    store.Menu();

                    break;
                case 3:
                    Weather weather = new Weather();
                    weather.ChoosingWeather();
                    weather.ChoosingTemperature();

                    break;
                case 2:
                    player.receipe.SetRecipe();
                    

                    break;

                case 4:

                    break;
            }





        }





    }
}