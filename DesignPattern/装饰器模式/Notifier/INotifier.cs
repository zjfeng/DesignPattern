using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.Notifier
{
    internal interface INotifier
    {
        public void Send(string message);
    }
}
