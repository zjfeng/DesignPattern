using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式.家居中枢
{
    internal abstract class Instrument
    {
        public abstract void TurnOn();

        public abstract void TurnOff();
    }
}
