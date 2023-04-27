using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + "with Milk";
        }
        public override double cost()
        {
            return .15 + beverage.cost();
        }
    }
}
