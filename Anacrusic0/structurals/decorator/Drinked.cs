using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace decorator
{
    public abstract class Drinked
    {
        protected Drinked drinked;
        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public abstract double GetPrice();
        public abstract string GetDescription();
    }
}