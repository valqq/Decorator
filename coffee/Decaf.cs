using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }
        public override double cost()
        {
            return 1.50;
        }
    }
}
