using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decorator
{
    public class Cream: Drinked
    {
        public Cream()
        {
            base.drinked = drinked;
            drinked.Price = drinked.GetPrice() + 400;
        }
        public override string GetDescription()
        {
            return $"{drinked.GetDescription()} con crema";
        }

        public override double GetPrice()
        {
            return drinked.Price;
        }
    }
}