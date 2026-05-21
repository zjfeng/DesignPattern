using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店.Pizza
{
    internal class GreekPizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("GreekPizza烘焙");
        }

        public override void Box()
        {
            Console.WriteLine("GreekPizza打包");
        }

        public override void Cut()
        {
            Console.WriteLine("GreekPizza切片");
        }

        public override void Prepare()
        {
            Console.WriteLine("准备GreekPizza");
        }
    }
}
