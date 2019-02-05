using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Day
    {
        private int daysLeft;
        private int hoursLeft;
        private int forcastCounter = 0;
        private string todaysWeather;
        Weather weather = new Weather();
       
        
        public void StartDay()
        {
            
            if (forcastCounter == 7)
            {
                forcastCounter = 0;
            }
            if (forcastCounter == 0)
            {
                weather.UpdateForcast();
            }
            ChangeWeather();
            Console.WriteLine(todaysWeather);
            
        }

        public void ChangeHour()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeWeather()
        {
            todaysWeather = weather.currentForcast[forcastCounter];
            forcastCounter++;
        }
    }
}