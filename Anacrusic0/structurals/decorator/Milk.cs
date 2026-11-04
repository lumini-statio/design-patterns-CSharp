using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decorator
{
    public class Milk : Drinked
    {
        public Milk()
        {
        }

        public Milk(Drinked drinked)
        {
            base.drinked = drinked;
            drinked.Price = drinked.GetPrice() + 300;
        }

        public override string GetDescription()
        {
            return $"{drinked.GetDescription()} con leche";
        }

        public override double GetPrice()
        {
            return drinked.Price;
        }
    }
}