using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.调料
{
    internal class Mocha : Seasoning
    {
        public override decimal Cost()
        {
            return 0.59m;
        }

        public override string GetDescription()
        {
            return "Mocha";
        }
    }
}
