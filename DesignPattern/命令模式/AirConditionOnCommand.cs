using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class AirConditionOnCommand : ICommand
    {
        private AirCondition _airCondition;
        public AirConditionOnCommand(AirCondition airCondition)
        {
            _airCondition = airCondition;
        }
        public void Execute()
        {
            _airCondition.TurnOn();
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            _airCondition.TurnOff();
        }
    }
}
