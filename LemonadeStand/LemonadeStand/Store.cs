using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {

        public Store(Player player, Inventory inventory)
        {

        }
        public Action StoreMenu(Player player, Inventory inventory)
        {
            int optionChoice;
            UI.DisplayInfo("What would you like to buy? \n Enter 0 for Cups, 1 for Lemons, 2 for Sugar, and 3 for Ice.");
            optionChoice = UI.NumberCheck();

            switch (optionChoice)
            {
                case 0:
                    BuyCups(player, inventory);
                    break;
                case 1:
                    BuyLemons(player, inventory);
                    break;
                case 2:
                    BuySugar(player, inventory);
                    break;
                case 3:
                    BuyIce(player, inventory);
                    break;
               

            }

            UI.DisplayInfo("Would you like to make another purchase?");
            string yesNoCatch = UI.YesNoCheck();

            if(yesNoCatch == "yes")
            { 
            return StoreMenu(player, inventory);
            }
            else
            {
                return null;
            }
        }
      

        public void BuyLemons(Player player, Inventory inventory)
        {
               
        }

        public void BuySugar(Player player, Inventory inventory)
        {
          
        }

        public void BuyCups(Player player, Inventory inventory)
        {

        }

        public void BuyIce(Player player, Inventory inventory)
        {
            
        }
    }
}