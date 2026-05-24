using DesignPattern.Base;
using DesignPattern.策略模式.Duck.能力;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.Duck
{
    internal class StrategyPatternDemo : DemoRunner
    {
        public override string Description => "策略模式-Duck";

        public override void Excute()
        {
            Duck mallardDuck = new MallardDuck();
            
            mallardDuck.Display();
            mallardDuck.Fly();
            mallardDuck.Quack();
            mallardDuck.Swim();
        }
    }
}
