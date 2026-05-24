using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.Duck
{
    internal class RedheadDuck : Duck
    {
        public override void Display()
        {
            Console.WriteLine("这是红头鸭");
        }
    }
}
