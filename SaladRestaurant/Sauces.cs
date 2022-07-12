using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public abstract class Sauces:ISalad
    {
        protected ISalad aSalad;

        public Sauces(ISalad salad)
        {
            aSalad = salad;
        }


        public ISalad getSalad()
        {
            return aSalad;
        }

        public void setSalad(ISalad aSalad)
        {
            this.aSalad = aSalad;
        }
    }
}
