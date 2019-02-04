using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class PickyCustomer:Customer
    {


        protected override int CheckPrice()
        {

            return 0;
        }

        protected override int CheckWeather()
        {
            
            return 0;
        }


    }
}
