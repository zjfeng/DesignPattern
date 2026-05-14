using DesignPattern.装饰器模式.咖啡店.咖啡;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.调料
{
    internal abstract class Seasoning : Beverage
    {
        private Beverage beverage;

        public Seasoning(Beverage beverage)
        {
            this.beverage = beverage;
        }
    }
}
