using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.Notifier
{
    internal class LoggingDecorator : Decorator
    {
        public LoggingDecorator(INotifier notifier) : base(notifier)
        {
            
        }

        public override void Send(string message)
        {
            Console.WriteLine("记录日志");
            base.Send(message);
        }
    }
}
