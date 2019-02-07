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

        public void HowToPlay()
        {
            UI.DisplayInfo("Lets teach you how to play. Once you name yourself, you will be starting up your Lemonade Stand. \n You'll want to buy ingredients by going to the store. ");
            UI.DisplayInfo("\nOnce in the store, buy everything you need. Don't run out of money too quick! \n Now go back and set a recipe for your lemonade stand, which will take ingredients you have every 10 successful sales, to make another batch.");
            UI.DisplayInfo("\nThis means you'll want to have enough ingredients to complete a day!\nWhen the recipe is set, you can start your day and sell lemonade!\nAt the end of the day, your profit is shown.\nThis process will continue for the amount of days played.");
            UI.DisplayInfo("\n\nSimple, right?");
        }
    }
}