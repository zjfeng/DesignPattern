using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.Duck.能力
{
    internal class SwimWithFeet : ISwimBehavior
    {
        public void Swim()
        {
            Console.WriteLine("用脚游泳");
        }
    }
}
