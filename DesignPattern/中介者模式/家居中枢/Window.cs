using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式.家居中枢
{
    internal class Window : Instrument
    {
        public override void TurnOff()
        {
            Console.WriteLine("close window");
        }

        public override void TurnOn()
        {
            Console.WriteLine("open window");
        }
    }
}
