using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class Button
    {
        private ICommand _command;

        public Button(ICommand command)
        {
            this._command = command;
        }

        public void Press()
        {
            _command.Execute();
        }
    }
}
