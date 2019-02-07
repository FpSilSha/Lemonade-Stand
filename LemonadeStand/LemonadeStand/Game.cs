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
                WorkingDay();

                Console.ReadKey();
            }
            while (gameLength > 0);


            
          
        }
       
        public List<Customer> CustomerGenerator()
        {
            int customerSet;

            if (day.dayOfWeek == "Friday")
            {
                customerSet = 100;
            }
            else if (day.dayOfWeek == "Saturday" || day.dayOfWeek == "Sunday")
            {
                customerSet = 120;
            }
            else
            {
                customerSet = 85;
            }
            List<Customer> customers = new List<Customer>();
            for(int i =0; i < customerSet; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
            return customers;
        }
        
        public void WorkingDay()
        {
           List<Customer> customers = CustomerGenerator();
           
        }

        public void DisplayRules()
        {
            UI.DisplayInfo("Welcome to Lemonade Stand! \n The game is simple: sell lemonade to customers and make money! \n Don't go bankrupt on your quest for cash!");

        }

        
    }
}