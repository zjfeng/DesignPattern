using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class AirCondition
    {
        public int Temperature = 25;
        public void TurnOn()
        {
            Console.WriteLine("AirCondition is turned on.");
        }

        public void TurnOff()
        {
            Console.WriteLine("AirCondition is turned off.");
        }

        public void SetTemperature(int temp)
        {
            Temperature = temp;
            Console.WriteLine($"AirCondition temperature set to {temp} degrees.");
        }
    }
}
