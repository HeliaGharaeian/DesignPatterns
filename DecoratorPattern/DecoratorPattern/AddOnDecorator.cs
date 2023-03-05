using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class AddOnDecorator : IBeverage
    {
        protected IBeverage _beverage;
        public AddOnDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public virtual int Cost()
        {
            return _beverage.Cost();
        }
    }
}
