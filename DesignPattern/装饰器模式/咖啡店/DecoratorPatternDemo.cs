using DesignPattern.Base;
using DesignPattern.装饰器模式.咖啡店.咖啡;
using DesignPattern.装饰器模式.咖啡店.调料;
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
            Beverage darkRoast = new DarkRoast();
            darkRoast.AddSeasoning(new Mocha());
            darkRoast.AddSeasoning(new Mocha());
            darkRoast.AddSeasoning(new Whip());
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");
        }
    }
}