using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {


       Player playerOne = new Player();
       Day day = new Day();
        LemonadeStand LemStand = new LemonadeStand();
        Store store = new Store();

        public void RunGame()
        {
            UI.DisplayInfo("How many days would you like to play for? We recommend at least a week(7)!");
            int gameLength = UI.IntegerNumberCheck();

                day.StartDay();

            Console.ReadKey();
          
        }
       
        
    }
}