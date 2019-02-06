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
        LemonadeRecipe standRecipe = new LemonadeRecipe();
        Inventory inventory = new Inventory();
        
        
        public void createNewPitcher()
        {
            removeLemons();
            removeSugar();
            removeIce();
            cupsInPitcher = 10;
        }

        private void removeLemons()
        {
            if(standRecipe.numberOfLemons < inventory.lemons.Count)
            {                           
                 for (int i = standRecipe.numberOfLemons; i > 0; i--)
                  {
                    inventory.lemons.RemoveAt(inventory.lemons.Count - 1);
                 }
            }
        }
        private void removeSugar()
        {
            if (standRecipe.numberOfCupsOfSugar < inventory.CupsOfSugarCount.Count)
            {
                for (int i = standRecipe.numberOfCupsOfSugar; i > 0; i--)
                {
                    inventory.CupsOfSugarCount.RemoveAt(inventory.CupsOfSugarCount.Count - 1);
                }
            }
        }
        private void removeIce()
        {
            if (standRecipe.numberOfIceCubes < inventory.IceCubesCount.Count)
            {
                for (int i = standRecipe.numberOfIceCubes; i > 0; i--)
                {
                    inventory.IceCubesCount.RemoveAt(inventory.IceCubesCount.Count - 1);
                }
            }
        }


    }
}