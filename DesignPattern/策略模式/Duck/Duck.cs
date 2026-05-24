using DesignPattern.策略模式.Duck.能力;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.Duck
{
    internal abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;
        ISwimBehavior swimBehavior;

        public abstract void Display();
        public void Swim()
        {
            swimBehavior.Swim();
        }
        public void Quack()
        {
            quackBehavior.Quack();
        }
        public void Fly()
        {
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }

        public void SetSwimBehavior(ISwimBehavior swimBehavior)
        {
            this.swimBehavior = swimBehavior;
        }
    }
}
