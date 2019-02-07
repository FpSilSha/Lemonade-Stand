using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public static class UI
    {


        public static void DisplayInfo(string words)
        {
            Console.WriteLine(words);
        }

        public static void DisplayCurrentDay(string day, string weather)
        {
            Console.WriteLine($"\nToday is {day} and it is {weather} outside.");
        }
        public static void DisplayForcast(List<string> weatherForcast, List<string> daysOfTheWeek)
        {
            int loopCount;
            Console.WriteLine("The current forcast for this week is:");
            for (loopCount = 0; loopCount < weatherForcast.Count; loopCount++)
            {
                Console.WriteLine($"\n{daysOfTheWeek[loopCount]} will be {weatherForcast[loopCount]}");
            }
        }
       public static string SetName()
        {
            Console.WriteLine("What name what you like to provide?");
            string nameCatch = Console.ReadLine();
            return nameCatch;
        }

        public static int IntegerNumberCheck()
        {
            int numberCatch = -1;
            int tryCounter = 0;
            do
            {
                Console.WriteLine("Please enter a whole number");
                if (tryCounter > 0)
                    Console.WriteLine("Please keep the whole number positive, and realistic");
                try
                {
                    numberCatch = Convert.ToInt16(Console.ReadLine());
                    
                }
                catch (OverflowException)
                {
                    Console.WriteLine("That input value is way too big!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not exactly the type of input we are looking for. Please enter a number.");
                }
                tryCounter++;
            }
            while (numberCatch < 0);

            return numberCatch;

        }

        public static string YesNoCheck()
        {
            bool cont = true;
            string yesNoCatch = null;
            do
            {
                try
                {
                    DisplayInfo("\nPlease enter yes or no:\n");
                    yesNoCatch = Console.ReadLine();
                }
                catch(OverflowException)
                {
                    DisplayInfo("Input wasn't valid. Please choose again.");
                }
                    yesNoCatch = yesNoCatch.ToLower();
                if (yesNoCatch == "yes" || yesNoCatch == "no")
                {
                    cont = false;
                }
               
            }
            while (cont);
            return yesNoCatch;
        }

        public static decimal DecimalNumberCheck()
        {
            decimal numberCatch = -1.0m;
            int tryCounter = 0;
            do
            {
                Console.WriteLine(" \nPlease enter a decimal from 0.0 to 1.00");
                if (tryCounter > 0)
                    Console.WriteLine("Please keep the decimal positive, and within the range");
                try
                {
                    numberCatch = Convert.ToDecimal(Console.ReadLine());

                }
                catch (OverflowException)
                {
                    Console.WriteLine("That input value is way too big!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not exactly the type of input we are looking for. Please enter a number.");
                }
                tryCounter++;
            }
            while (numberCatch < 0.0m && numberCatch > 1.0m);

            return numberCatch;
        }

        public static void DisplayInventory(Inventory inventory)
        {
            UI.DisplayInfo($"This is your current inventory:\nLemons:{inventory.lemons.Count}\nCups of sugar:{inventory.CupsOfSugarCount.Count}\nIceCubes:{inventory.IceCubesCount.Count}\nCups{inventory.CupsCount.Count}");
        }


    }
}