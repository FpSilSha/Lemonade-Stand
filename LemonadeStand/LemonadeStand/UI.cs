using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public static class UI
    {


       public static string SetName()
        {
            Console.WriteLine("What name what you like to provide?");
            string nameCatch = Console.ReadLine();
            return nameCatch;
        }

        public static int NumberCheck()
        {
            int numberCatch = -1;
            int tryCounter = 0;
            do
            {
                Console.WriteLine("Please enter a whole number between 0 - 15.");
                if (tryCounter > 0)
                    Console.WriteLine("Please keep the whole number between 0 and 15.");
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
                    Console.WriteLine("That is not exactly the type of input we are looking for. Please enter a number");
                }
                tryCounter++;
            }
            while (numberCatch < 0 && numberCatch > 15);

            return numberCatch;

        }







    }
}