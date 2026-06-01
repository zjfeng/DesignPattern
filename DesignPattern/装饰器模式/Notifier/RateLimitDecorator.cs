using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.Notifier
{
    internal class RateLimitDecorator : Decorator
    {
        public RateLimitDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("限频");
            Thread.Sleep(2000);
            base.Send(message);
        }
    }
}
