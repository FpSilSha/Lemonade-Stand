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
        private string dayOfWeek;
        List<string> daysOfTheWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
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
                UI.DisplayForcast(weather.currentForcast, daysOfTheWeek);
            }
           
            ChangeDay();
            ChangeWeather();

            UI.DisplayCurrentDay(dayOfWeek, todaysWeather);
        }

        public void ChangeDay()
        {
            dayOfWeek = daysOfTheWeek[forcastCounter];
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