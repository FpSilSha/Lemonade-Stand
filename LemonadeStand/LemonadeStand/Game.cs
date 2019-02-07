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
            DisplayRules();
            HowToPlay();
            Console.ReadKey();
            playerOne.name = UI.SetName();
            UI.DisplayInfo(" How many days would you like to play for? We recommend at least a week(7)!");            
            int gameLength = UI.IntegerNumberCheck();
            LemStand.standRecipe.SetRecipe();        
            do
            {
                Console.Clear();
                day.StartDay();
                UI.DisplayInventory(LemStand.inventory);
                StoreCheck();
                Console.Clear();
                LemStand.SetCupPrice();
                WorkingDay();
                LemStand.CalculateDailyProfit();
                LemStand.GiveMoneyToPlayer(playerOne);
                LemStand.CalculateTotalProfit();
                LemStand.ResetLemonadeStand();
                UI.DisplayInfo($"You have {gameLength} days left!");
                Console.ReadKey();
                Console.Clear();

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
            foreach(Customer customer in customers)
            {
                if(LemStand.cupsInPitcher == 0)
                {
                    LemStand.CreateNewPitcher();
                }
                customer.BuyLemonade(day, LemStand);
            }
            
        }

        public void DisplayRules()
        {
            UI.DisplayInfo(" Welcome to Lemonade Stand! \n The game is simple: sell lemonade to customers and make money! \n Don't go bankrupt on your quest for cash!");

        }

        public void HowToPlay()
        {
            UI.DisplayInfo(" Lets teach you how to play. Once you name yourself, you will be starting up your Lemonade Stand. \n You'll want to buy ingredients by going to the store. ");
            UI.DisplayInfo("\n Once in the store, buy everything you need. Don't run out of money too quick! \n Now go back and set a recipe for your lemonade stand\n The recipe will take ingredients you have every 10 successful sales, to make another batch.");
            UI.DisplayInfo("\n This means you'll want to have enough ingredients to complete a day!\n When the recipe is set, you can start your day and sell lemonade!\n At the end of the day, your profit is shown.\n This process will continue for the amount of days played.");
            UI.DisplayInfo("\n\n Simple, right?");
        }

        public void StoreCheck()
        {
            string answer;
            UI.DisplayInfo(" Would you like to go to the store?");
            answer = UI.YesNoCheck();
            if(answer == "yes")
            {
                store.StoreMenu(playerOne,LemStand.inventory);
            }
        }
    }
}