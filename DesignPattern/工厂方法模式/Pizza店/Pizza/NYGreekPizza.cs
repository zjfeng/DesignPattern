using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店.Pizza
{
    internal class NYGreekPizza : GreekPizza
    {
        public override void Prepare()
        {
            Console.WriteLine("准备NYGreekPizza");
        }
    }
}
