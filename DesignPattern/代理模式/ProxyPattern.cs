using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    internal static class ProxyPattern
    {
        public static void Test()
        {
            Suitor suitor = new Suitor("张三");
            Errand errand = new Errand("李四");
            errand.SetSuitor(suitor);
            errand.GiveChocolate();
            errand.GiveDolls();
            errand.GiveFlowers();
        }
    }
}
