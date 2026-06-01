using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.Notifier
{
    internal abstract class Decorator : INotifier
    {
        private INotifier _notifier;

        public Decorator(INotifier notifier) { 
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
