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
       

        public void RunGame()
        {
           

                day.StartDay();

            Console.ReadKey();
          
        }
       

        
    }
}