using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式
{
    internal class DarkRoast : Beverage
    {
        public DarkRoast(Size size) {
            Description = new List<string> { "深焙咖啡" };
            Size = size;
        }

        public override decimal Cost()
        {
            return 10;
        }
    }
}
