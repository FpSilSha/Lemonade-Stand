using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public abstract class Customer
    {
        
        protected int weatherModifier;
        protected int priceModifier;
        protected int buyChance = 90;
        

        public void BuyLemonade()
        {
            weatherModifier = CheckWeather();
            priceModifier = CheckPrice();



        }

        protected virtual int CheckWeather()
        {

            return 0;
        }



        protected virtual int CheckPrice()
        {

            return 0;
        }
      
        




    }
}