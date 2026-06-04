using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class MacroCommand : ICommand
    {
        private IList<ICommand> _commands;

        public MacroCommand(IList<ICommand> commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (ICommand command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            Console.WriteLine("Undo");
            foreach (ICommand command in _commands.Reverse())
            {
                command.Undo();
            }
        }
    }
}
