using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class AirConditionOffCommand : ICommand
    {
        private AirCondition _airCondition;
        public AirConditionOffCommand(AirCondition airCondition)
        {
            _airCondition = airCondition;
        }
        public void Execute()
        {
            _airCondition.TurnOff();
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            _airCondition.TurnOn();
        }
    }
}
