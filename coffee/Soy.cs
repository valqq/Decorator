using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class Soy : CondimentDecorator
    {
        Beverage beverage;
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + "with soy";
        }
        public override double cost()
        {
            return .25 + beverage.cost();
        }
    }
}
