using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class CaramelDecorator : AddOnDecorator
    {
        public CaramelDecorator(IBeverage beverage) : base(beverage)
        {
        }
        public override int Cost()
        {
            return _beverage.Cost() + 1;
            
        }
    }
}
