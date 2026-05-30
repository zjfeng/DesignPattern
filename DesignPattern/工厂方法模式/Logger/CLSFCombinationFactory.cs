using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Logger
{
    internal class CLSFCombinationFactory : CombinationFactory
    {
        public override Formatter CreateFormatter()
        {
            return new SimpleFormatter();
        }

        public override Logger CreateLogger()
        {
            return new ConsoleLogger();
        }
    }
}
