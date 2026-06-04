using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class RemoteControl
    {
        private Stack<ICommand> _undoCommands = new Stack<ICommand>();
        private Stack<ICommand> _redoCommands = new Stack<ICommand>();

        public void PressButton(ICommand command)
        {
            command.Execute();
            _undoCommands.Push(command);
        }

        public void Undo()
        {
            if (_undoCommands.Count > 0)
            {
                ICommand command = _undoCommands.Pop();
                command.Undo();

                _redoCommands.Push(command);
            }
        }

        public void Redo() 
        {
            if (_redoCommands.Count > 0)
            {
                ICommand command = _redoCommands.Pop();
                command.Undo();

                _undoCommands.Push(command);
            }
        }
    }
}
