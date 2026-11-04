using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decorator
{
    public class NormalCoffee : Drinked
    {

        public NormalCoffee()
        {
            base.Price = 1500;
        }
        public override string GetDescription()
        {
            return "Cafe normal";
        }

        public override double GetPrice()
        {
            base.Price = 1500;
            return base.Price;
        }
    }
}