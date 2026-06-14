using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.创建者模式
{
    internal class BuilderPatternDemo : DemoRunner
    {
        public override string Description => "Builder Pattern";

        public override void Excute()
        {
            EmailMessage emailMessage = new Director("aaa", "bbb").BuildEmail();
        }
    }
}
