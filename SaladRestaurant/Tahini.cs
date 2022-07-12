using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class Tahini:Sauces
    {
        Salad baseSalad = null;
        protected double p_Price = 0.0;
        
        protected Sauces(Salad objSalad)
        {
            baseSalad = objSalad;
        }      
        public override double  GetPrice()
        {

        return p_Price + baseSalad.GetPrice();
        }
    }
}
