using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class CurtainOffCommand : ICommand
    {
        private Curtain _curtain;

        public CurtainOffCommand(Curtain curtain)
        {
            _curtain = curtain;
        }

        public void Execute()
        {
            _curtain.TurnOff();
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            _curtain.TurnOn();
        }
    }
}
