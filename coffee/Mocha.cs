using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + "with Mocha";
        }
        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}
