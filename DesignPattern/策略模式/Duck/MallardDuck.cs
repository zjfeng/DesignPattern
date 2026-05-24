using DesignPattern.策略模式.Duck.能力;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.Duck
{
    internal class MallardDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("这是绿头鸭");
        }

        public MallardDuck()
        {
            SetSwimBehavior(new NoSwim());
            SetQuackBehavior(new QuackQuack());
            SetFlyBehavior(new FlyWithWings());
        }
    }
}
