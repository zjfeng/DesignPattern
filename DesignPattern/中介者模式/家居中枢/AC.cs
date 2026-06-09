using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式.家居中枢
{
    internal class AC : Instrument
    {
        public override void TurnOff()
        {
            Console.WriteLine("close ac");
        }

        public override void TurnOn()
        {
            Console.WriteLine("open ac");
        }

        public void SetCold()
        {
            Console.WriteLine("set ac to cold");
        }

        public void SetHot()
        {
            Console.WriteLine("set ac to hot");
        }
    }
}
