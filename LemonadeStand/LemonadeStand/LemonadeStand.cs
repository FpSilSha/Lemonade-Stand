using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class LemonadeStand
    {
        public int cupsInPitcher = 10;
        internal decimal pricePerCup = 0.0m;
        internal int cupsSold = 0;
        internal LemonadeRecipe standRecipe = new LemonadeRecipe();
        internal Inventory inventory = new Inventory();
        internal decimal dayProfit;
        internal decimal totalProfit;
        
        public void SetCupPrice()
        {
            UI.DisplayInfo("\n What price would you like to set a cup of lemonade to?");
            pricePerCup = UI.DecimalNumberCheck();
        }
        public void CreateNewPitcher()
        {
            RemoveLemons();
            RemoveSugar();
            RemoveIce();
            cupsInPitcher = 10;
        }

        private void RemoveLemons()
        {
            if(standRecipe.numberOfLemons < inventory.lemons.Count)
            {                           
                 for (int i = standRecipe.numberOfLemons; i > 0; i--)
                  {
                    inventory.lemons.RemoveAt(inventory.lemons.Count - 1);
                 }
            }
        }
        private void RemoveSugar()
        {
            if (standRecipe.numberOfCupsOfSugar < inventory.CupsOfSugarCount.Count)
            {
                for (int i = standRecipe.numberOfCupsOfSugar; i > 0; i--)
                {
                    inventory.CupsOfSugarCount.RemoveAt(inventory.CupsOfSugarCount.Count - 1);
                }
            }
        }
        private void RemoveIce()
        {
            if (standRecipe.numberOfIceCubes < inventory.IceCubesCount.Count)
            {
                for (int i = standRecipe.numberOfIceCubes; i > 0; i--)
                {
                    inventory.IceCubesCount.RemoveAt(inventory.IceCubesCount.Count - 1);
                }
            }
        }

        public void CalculateDailyProfit()
        {

            dayProfit = pricePerCup * Convert.ToDecimal(cupsSold);
            

        }

        public void CalculateTotalProfit()
        {
            totalProfit += dayProfit;
            
        }

        public void ResetLemonadeStand()
        {
            cupsInPitcher = 10;
            dayProfit = 0.0m;

        }

        public void GiveMoneyToPlayer(Player player)
        {
            player.wallet += dayProfit;
        }
    }
}