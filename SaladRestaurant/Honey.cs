using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class Honey:Sauces
    {
        public Honey(ISalad salad):base(salad)
        {
         
        }
        public string doSalad()
        {
            string type = aSalad.doSalad();
            return type + addHoney();
        }
        private string addHoney()
        {
            return "+Honey";
        }

        

    }
}
