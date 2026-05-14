using DesignPattern.装饰器模式.咖啡店.咖啡;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.调料
{
    internal class Soy : Seasoning
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override decimal Cost()
        {
            return 0.41m + beverage.Cost();
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + " Soy";
        }
    }
}
