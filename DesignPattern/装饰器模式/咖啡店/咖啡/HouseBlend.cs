using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.咖啡
{
    internal class HouseBlend : Beverage
    {
        public override decimal Cost()
        {
            return 1.99m;
        }

        public override string GetDescription()
        {
            return "House Blend Coffee，综合咖啡";
        }
    }
}
