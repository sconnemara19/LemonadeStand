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
            days = new List<Day>();
            

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
                    DisplayWeather();
                    break;
                case 2:
                    player.receipe.SetRecipe();
                    

                    break;

                case 4:

                    break;
            }





        }

        public void DisplayWeather()
        {
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine(days[i].weather.temperature);
                Console.WriteLine(days[i].weather.predictedForecast);
            }
        }

        public void CreateDays()
        {
            for(int i = 0; i < 7; i++)
            {
                Day day = new Day();
                days.Add(day);
            }
        }


    }
}