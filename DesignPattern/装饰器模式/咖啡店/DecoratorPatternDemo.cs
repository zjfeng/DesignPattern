using DesignPattern.Base;
using DesignPattern.装饰器模式.咖啡店.咖啡;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店
{
    internal class DecoratorPatternDemo : DemoRunner
    {
        public override string Description => "装饰器模式.咖啡店";

        public override void Excute()
        {
            HouseBlend houseBlend = new HouseBlend();
            Console.WriteLine($"{houseBlend.GetDescription()} ${houseBlend.Cost()}");
            DarkRoast darkRoast = new DarkRoast();
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");
        }
    }
}