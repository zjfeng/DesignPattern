using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.Notifier
{
    internal class DecoratorPatternDemo : DemoRunner
    {
        public override string Description => "装饰器模式-Notifier";

        public override void Excute()
        {
            EmailNotifier emailNotifier = new EmailNotifier();
            LoggingDecorator loggingDecorator = new LoggingDecorator(emailNotifier);
            LoggingDecorator loggingDecorator2 = new LoggingDecorator(loggingDecorator);
            RateLimitDecorator rateLimitDecorator = new RateLimitDecorator(loggingDecorator2);
            EncryptionDecorator encryptionDecorator = new EncryptionDecorator(rateLimitDecorator);
            encryptionDecorator.Send("ahhahaha");
        }
    }
}
