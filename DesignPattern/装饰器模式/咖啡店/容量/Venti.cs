using DesignPattern.装饰器模式.咖啡店.咖啡;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.容量
{
    internal class Venti : Size
    {
        public Venti(Beverage beverage) : base(beverage)
        {
        }

        public override decimal Cost()
        {
            return 0.8m + beverage.Cost();
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + " Venti Size";
        }
    }
}
