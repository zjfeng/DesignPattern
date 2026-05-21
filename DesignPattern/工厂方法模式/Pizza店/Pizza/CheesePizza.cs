using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店.Pizza
{
    internal class CheesePizza : Pizza
    {
        public override void Bake()
        {
            Console.WriteLine("CheesePizza烘焙");
        }

        public override void Box()
        {
            Console.WriteLine("CheesePizza打包");
        }

        public override void Cut()
        {
            Console.WriteLine("CheesePizza切片");
        }

        public override void Prepare()
        {
            Console.WriteLine("准备CheesePizza");
        }
    }
}
