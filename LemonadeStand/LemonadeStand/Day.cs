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
            forcastCounter++;
            if(forcastCounter == 7)
            {
                forcastCounter = 0;
            }
            ChangeWeather();
            Console.WriteLine(todaysWeather);
            Console.ReadKey();
        }

        public void ChangeHour()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeWeather()
        {
            todaysWeather = weather.currentForcast[forcastCounter-1];
            
        }
    }
}