using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class HealthyTacoSalad: Salad
    {
        private double GS_Price = 351.5;
        public override double GetPrice()
        {
            return GS_Price;
        }
    }
}
