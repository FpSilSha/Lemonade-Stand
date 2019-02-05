using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public  class Customer
    {
        
        private int weatherModifier;
        private int priceModifier;
        private int buyChance;
        private string customerType;

        public Customer(LemonadeStand lemonadeStand)
        {
            ChooseType();
            SetChance();
        }

        private void SetChance()
        {
            switch (customerType)
            {
                case "mild":
                    buyChance = 70;
                    break;
                case "picky":
                    buyChance = 60;
                    break;
                case "preferred":
                    buyChance = 85;
                    break;
            }
        }
        public void ChooseType()
        {
            Random rng = new Random();
            int randomNumber = rng.Next(0,101);
            if (randomNumber <= 30)
            {
                customerType = "mild";
            }
            else if (randomNumber >=80)
            {
                customerType = "picky";
            }
            else
            {
                customerType = "preferred";
            }
        }

        //public void BuyLemonade()
        //{
        //    weatherModifier = CheckWeather();
        //    priceModifier = CheckPrice();



        //}

        //private int CheckWeather(Weather weather)
        //{
        //    weather.todaysWeather;
        //    return 0;
        //}



        private int CheckPrice()
        {

            return 0;
        }
      
        




    }
}