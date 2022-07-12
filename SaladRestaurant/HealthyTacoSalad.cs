using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class HealthyTacoSalad: Salad, ISalad
    {
        public string doSalad()
        {
            return "HealthyTacoSalad";
        }
        public HealthyTacoSalad()
        {
            this.myPrice = 45.00;
            this.description = "HealthyTacoSalad";
        }
    }
}
