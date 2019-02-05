using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Weather
    {
        
        public List<string> currentForcast = new List<string>();
        
        List<string> possibleWeather = new List<string>() { "Sunny", "Rainy", "Cloudy" };
        Random rnd = new Random();

      

        

        public void UpdateForcast()
        {
            currentForcast = null;
            List<string> newForcast = new List<string>();
            int dayCounter = 7;
            while(dayCounter > 0)
            {
                int index = rnd.Next(possibleWeather.Count);
                newForcast.Add(possibleWeather[index]);
                dayCounter--;
            }
            currentForcast = newForcast;
            
            
                

        }
    }
}