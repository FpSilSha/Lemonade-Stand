using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Inventory
    {
       internal List<Lemon> lemons = new List<Lemon>();
       internal List<CupsOfSugar> CupsOfSugarCount = new List<CupsOfSugar>();
       internal List<IceCubes> IceCubesCount = new List<IceCubes>();
       internal List<Cups> CupsCount = new List<Cups>();
    }
}