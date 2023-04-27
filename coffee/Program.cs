using System;

namespace coffee
{
    class Program
    {
        public static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            espresso = new Mocha(espresso);
            espresso = new Mocha(espresso);
            Console.WriteLine(espresso.getDescription() + " $" + espresso.cost());

            Beverage houseBlend = new HouseBlend();
        }
    }
}
