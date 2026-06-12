using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    internal class ProxyPatternDemo : DemoRunner
    {
        public override string Description => "Proxy Pattern";

        public override void Excute()
        {
            IImage proxy = new ImageProxy("aaa");
            IImage proxy1 = new ImageProxy("bbb");
            proxy.Display();
            proxy1.Display();
            proxy.Display();
        }
    }
}
