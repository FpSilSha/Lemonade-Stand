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

            do
            {
                day.StartDay();


                Console.ReadKey();
            }
            while (gameLength > 0);
                day.StartDay();

            
          
        }
       
        public void CustomerCreator()
        {

        }
        
        public void WorkingDay()
        {
            Customer customer = new Customer();
            CustomerCreator();

        }
    }
}