using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Store
    {

        public Store()
        {

        }
        public Action StoreMenu(Player player, Inventory inventory)
        {
            int optionChoice;

            //DISPLAY PRICES FOR EVERYTHING
            
            UI.DisplayInfo("\nCurrent price of a lemon is .12. \nCurrent price of a cup of sugar is .09.\n Current price of ice cubes is .07.\nCurrent price of cups are .05 each.\n\n\nWhat would you like to buy? \n Enter 0 for Cups, 1 for Lemons, 2 for Sugar, and 3 for Ice.");
            
            optionChoice = UI.IntegerNumberCheck();

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
            UI.DisplayInfo("How many lemons would you like to purchase?");
            int lemonsRequested = UI.IntegerNumberCheck();
            player.wallet += - (Convert.ToDecimal(lemonsRequested) * .12m);
            for (int i = lemonsRequested; i > 0; i--)
            {
                Lemon lemon = new Lemon();
                inventory.lemons.Add(lemon);
            }

        }

        public void BuySugar(Player player, Inventory inventory)
        {
            UI.DisplayInfo("How man cups of sugar would you like to purchase?");
            int cupsOfSugarRequested = UI.IntegerNumberCheck();
            player.wallet += -(Convert.ToDecimal(cupsOfSugarRequested) * .09m);
            for (int i = cupsOfSugarRequested; i > 0; i--)
            {
                CupsOfSugar cupOfSugar = new CupsOfSugar();
                inventory.CupsOfSugarCount.Add(cupOfSugar);
            }

        }

        public void BuyCups(Player player, Inventory inventory)
        {
            UI.DisplayInfo("How many cups would you like to purchase?");
            int cupsRequested = UI.IntegerNumberCheck();
            player.wallet += -(Convert.ToDecimal(cupsRequested) * .05m);
            for (int i = cupsRequested; i > 0; i--)
            {
                Cups cup = new Cups();
                inventory.CupsCount.Add(cup);
            }

        }

        public void BuyIce(Player player, Inventory inventory)
        {
            UI.DisplayInfo("How many lemons would you like to purchase?");
            int iceCubesRequested = UI.IntegerNumberCheck();
            player.wallet += -(Convert.ToDecimal(iceCubesRequested) * .07m);
            for (int i = iceCubesRequested; i > 0; i--)
            {
                IceCubes iceCube = new IceCubes();
                inventory.IceCubesCount.Add(iceCube);
            }

        }
    }
}