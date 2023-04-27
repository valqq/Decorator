using System;
using System.Collections.Generic;
using System.Text;

namespace coffee
{
    public abstract class Beverage
    {
        public String description = "123";

        public virtual String getDescription()
        {
            return description;
        }
        public abstract double cost();
    }
}
