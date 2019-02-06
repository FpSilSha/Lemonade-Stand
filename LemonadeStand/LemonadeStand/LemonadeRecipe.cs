using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class LemonadeRecipe
    {
        int numberOfLemons;
        int numberOfIceCubes;
        int numberOfCupsOfSugar;

        public void SetRecipe()
        {
            UI.DisplayInfo("Time to make the recipe!!\n1=One pitcher equals 10 cups \n This means every 10 cups sold will decrease inventory by the numbers you're about to place!");
            UI.DisplayInfo("Please tell me how many lemons you would like to include per pitcher");
            numberOfLemons = UI.NumberCheck();            
            UI.DisplayInfo("Please tell me how many ice cubes you would like to include per pitcher");
            numberOfIceCubes = UI.NumberCheck();
            UI.DisplayInfo("Please tell me how many cups of sugar you would like to include per pitcher");
            numberOfCupsOfSugar = UI.NumberCheck();
        }



    }
}