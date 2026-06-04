using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class LightOnCommand : ICommand
    {
        private Light _light;

        public LightOnCommand(Light light) => this._light = light;

        public void Execute() => _light.TurnOn();

        public void Undo() {
            Console.WriteLine("Undo");
            _light.TurnOff();
        }
    }
}
