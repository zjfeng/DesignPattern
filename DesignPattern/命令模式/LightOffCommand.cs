using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class LightOffCommand : ICommand
    {
        private Light _light;

        public LightOffCommand(Light light) => this._light = light;

        public void Execute() => _light.TurnOff();

        public void Undo()
        {
            Console.WriteLine("Undo");
            _light.TurnOn();
        }
    }
}
