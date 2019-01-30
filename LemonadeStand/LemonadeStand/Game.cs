using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Game
    {
        public Customer Customer
        {
            get => default(Customer);
            set
            {
            }
        }

        public Day Day
        {
            get => default(Day);
            set
            {
            }
        }

        public LemonadeStand LemonadeStand
        {
            get => default(LemonadeStand.LemonadeStand);
            set
            {
            }
        }

        public Store Store
        {
            get => default(LemonadeStand.Store);
            set
            {
            }
        }

        public UserInterface UserInterface
        {
            get => default(LemonadeStand.UserInterface);
            set
            {
            }
        }

        public void RunGame()
        {
            throw new System.NotImplementedException();
        }

        public void PlayAgain()
        {
            throw new System.NotImplementedException();
        }
    }
}