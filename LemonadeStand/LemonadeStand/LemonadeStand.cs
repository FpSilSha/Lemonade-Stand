﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class LemonadeStand
    {
        private int currentRecipe;
        private int price;
        private int profit;

        public Inventory Inventory
        {
            get => default(LemonadeStand.Inventory);
            set
            {
            }
        }

        public void ChangePrice()
        {
            throw new System.NotImplementedException();
        }

        public void ChangeRecipe()
        {
            throw new System.NotImplementedException();
        }

        public void CalculateProfit()
        {
            throw new System.NotImplementedException();
        }
    }
}