using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class BroccoliSalad: Salad, ISalad
    {
        public string doSalad()
        {
            return "BroccoliSalad";
        }
        public BroccoliSalad()
        {
            this.myPrice = 49.00;
            this.description = "BroccoliSalad";
        }
    }
}
