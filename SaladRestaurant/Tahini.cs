using System;
using System.Collections.Generic;
using System.Text;

namespace SaladRestaurant
{
    public class Tahini:Sauces
    {
        public Tahini(ISalad salad) : base(salad)
        {

        }
        public string doSalad()
        {
            string type = aSalad.doSalad();
            return type + addTahini();
        }
        private string addTahini()
        {
            return "+Tahini";
        }
    }
}
