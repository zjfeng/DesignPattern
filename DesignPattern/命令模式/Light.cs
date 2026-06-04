using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class Light
    {
        public void TurnOn() => Console.WriteLine("开灯了");

        public void TurnOff() => Console.WriteLine("Off");
    }
}
