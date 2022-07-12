using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class GreekSalad: Salad, ISalad
    {
        public string doSalad()
        {
            return "GreekSalad";
        }
        public GreekSalad()
        {
            this.myPrice = 40.00;
            this.description = "GreekSalad";
        }
    }
}
