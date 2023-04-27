using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }
        public override double cost()
        {
            return 1.70;
        }
    }
}
