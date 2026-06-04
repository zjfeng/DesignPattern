using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal interface ICommand
    {
        public void Execute();

        public void Undo();
    }
}
