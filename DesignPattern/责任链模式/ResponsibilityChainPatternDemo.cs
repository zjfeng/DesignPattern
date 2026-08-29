using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.责任链模式
{
    internal class ResponsibilityChainPatternDemo : DemoRunner
    {
        public override string Description => "责任链模式";

        public override void Excute()
        {
            IApprover chain = new Manager();
            chain.SetNext(new Director()).SetNext(new CEO()).SetNext(new EndPoint());
            chain.Approve(100);
            chain.Approve(1000);
            chain.Approve(5000);
            chain.Approve(10000);
            chain.Approve(100000);
            chain.Approve(0);

        }
    }
}
