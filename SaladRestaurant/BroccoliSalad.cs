using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class BroccoliSalad: Salad
    {
        private double GS_Price = 200.0;
        public override double GetPrice()
        {
            return GS_Price;
        }
    }
}
