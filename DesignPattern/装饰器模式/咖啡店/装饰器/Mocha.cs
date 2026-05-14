using DesignPattern.装饰器模式.咖啡店.咖啡;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.装饰器
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override decimal Cost()
        {
            return 0.59m + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Mocha";
        }
    }
}
