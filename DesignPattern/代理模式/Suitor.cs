using DesignPattern.装饰者模式.QQ秀;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    internal class Suitor : Person, IGivePresent
    {

        public Suitor(string name) : base(name)
        {
        }

        public void GiveChocolate()
        {
            Console.WriteLine("让别人帮忙送巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine("让别人帮忙送洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine("让别人帮忙送花");
        }
    }
}
