using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decorator
{
    public class CoffeeStore
    {
        private Drinked _drinked;

        public CoffeeStore()
        {
            _drinked = new NormalCoffee();
            _drinked = new Cream();
        }
    }
}