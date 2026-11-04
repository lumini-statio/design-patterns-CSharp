using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decorator
{
    public class Chocolate : Drinked
    {
        public Chocolate()
        {
        }

        public Chocolate(Drinked drinked)
        {
            base.drinked = drinked;
            drinked.Price = drinked.GetPrice() + 500;
        }
        public override string GetDescription()
        {
            return $"{drinked.GetDescription()} con chocolate";
        }

        public override double GetPrice()
        {
            return drinked.Price;
        }
    }
}