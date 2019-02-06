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
        
        
        internal string dayOfWeek;
        List<string> daysOfTheWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Weather weather = new Weather();
       
       
        
        public void StartDay()
        {
            
            if (weather.forcastCounter == 7)
            {
                weather.forcastCounter = 0;
            }
            if (weather.forcastCounter == 0)
            {
                weather.UpdateForcast();
                UI.DisplayForcast(weather.currentForcast, daysOfTheWeek);
            }
           
            ChangeDay();
            weather.ChangeWeather();

            UI.DisplayCurrentDay(dayOfWeek, weather.todaysWeather);
        }

        public void ChangeDay()
        {
            dayOfWeek = daysOfTheWeek[weather.forcastCounter];
        }

        public void ChangeHour()
        {
            throw new System.NotImplementedException();
        }

        

        public void CustomerCreator()
        {


        }
    }
}