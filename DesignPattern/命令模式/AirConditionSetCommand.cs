using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class AirConditionSetCommand : ICommand
    {
        private AirCondition _airCondition;
        private int _previousTemperature;
        private int _temperature;

        public AirConditionSetCommand(AirCondition airCondition)
        {
            _airCondition = airCondition;
        }

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
        }

        public void Execute()
        {
            _previousTemperature = _airCondition.Temperature;
            _airCondition.SetTemperature(_temperature);
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            _airCondition.SetTemperature(_previousTemperature);
        }
    }
}
