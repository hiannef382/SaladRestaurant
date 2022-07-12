using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class GreekSalad: Salad
    {
        private double GS_Price = 250.0;
        public override double GetPrice()
        {
            return GS_Price;
        }
    }
}
