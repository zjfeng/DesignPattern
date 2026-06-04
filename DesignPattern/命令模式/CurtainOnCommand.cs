using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class CurtainOnCommand : ICommand
    {
        private Curtain _curtain;

        public CurtainOnCommand(Curtain curtain)
        {
            _curtain = curtain;
        }

        public void Execute()
        {
            _curtain.TurnOn();
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            _curtain.TurnOff();
        }
    }
}
