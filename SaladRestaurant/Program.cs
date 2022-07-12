using System;

namespace SaladRestaurant
{
    class Program
    {
        public static void Main(string[] args)
        {
            GreekSalad greek = new GreekSalad();
            SaladPriceInfo(greek);
            BroccoliSalad broccoli = new BroccoliSalad();
            SaladPriceInfo(broccoli);
            HealthyTacoSalad healthytaco =new HealthyTacoSalad();
            SaladPriceInfo(healthytaco);

            Honey honey=new Honey();
            SaladPriceInfo(honey);
            Tahini tahini=new Tahini();
            SaladPriceInfo(tahini);

            public static void SaladPriceInfo(Salad objSalad)
            {
                Console.WriteLine();
                Console.WriteLine("Price of Salad is: {0}", objSalad.GetPrice();
                Console.ReadKey();
            }

        }
    }
}
