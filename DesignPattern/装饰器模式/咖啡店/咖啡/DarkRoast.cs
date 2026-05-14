using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.咖啡
{
    internal class DarkRoast : Beverage
    {
        public override decimal Cost()
        {
            return 2.19m;
        }

        public override string GetDescription()
        {
            return "Dark Roast Coffee，深焙咖啡";
        }
    }
}
