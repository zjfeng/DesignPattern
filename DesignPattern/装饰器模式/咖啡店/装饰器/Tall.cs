using DesignPattern.装饰器模式.咖啡店.咖啡;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.装饰器
{
    internal class Tall : CondimentDecorator
    {
        public Tall(Beverage beverage) : base(beverage)
        {
        }

        public override decimal Cost()
        {
            return 0 + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Tall Size";
        }
    }
}
