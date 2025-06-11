using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式
{
    internal abstract class CondimentDecorator : Beverage
    {
        public override decimal Cost()
        {
            return 0;
        }
    }
}
