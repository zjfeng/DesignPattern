using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.Duck.能力
{
    internal class NoSwim : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("不会游泳");
        }
    }
}
