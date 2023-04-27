using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }
        public override double cost()
        {
            return 2.10;
        }
    }
}
