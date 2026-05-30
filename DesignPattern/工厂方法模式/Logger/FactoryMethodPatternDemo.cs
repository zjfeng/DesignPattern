using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Logger
{
    internal class FactoryMethodPatternDemo : DemoRunner
    {
        public override string Description => "工厂方法模式-Logger";

        public override void Excute()
        {
            CombinationFactory factory = new CLSFCombinationFactory();
            Logger logger = factory.CreateLogger();
            Formatter formatter = factory.CreateFormatter();

        }
    }
}
