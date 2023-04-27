using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string getDescription()
        {
            return beverage.getDescription() + "with whip";
        }
        public override double cost()
        {
            return .17 + beverage.cost();
        }
    }
}
