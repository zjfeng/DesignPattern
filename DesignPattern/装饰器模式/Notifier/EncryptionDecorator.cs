using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.Notifier
{
    internal class EncryptionDecorator : Decorator
    {
        public EncryptionDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("加密");
            base.Send(message + "阿阿八八啊八八啊八");
        }
    }
}
