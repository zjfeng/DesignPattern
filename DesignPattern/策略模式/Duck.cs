using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    abstract class Duck
    {
        public FlyBehavior _flyBehavior;

        public abstract void Quack();
        public abstract void Swim();
        public abstract void Display();

        public void Fly() {
            if (_flyBehavior == null)
            {
                Console.WriteLine("还没学会飞");
                return;
            }

            _flyBehavior.Fly();
        }

        public abstract void SetFlyBehavior(FlyBehavior flyBehavior);
    }

    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _flyBehavior = new FlyNoWay();
        }

        public override void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public override void Quack()
        {
            Console.WriteLine("Quack");
        }
        public override void Swim()
        {
            Console.WriteLine("Swim");
        }
        public override void Display()
        {
            Console.WriteLine("Display Mallard Duck");
        }
    }

    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            _flyBehavior = new FlyNoWay();
        }

        public override void SetFlyBehavior(FlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public override void Display()
        {
            Console.WriteLine("Display Red Head Duck");
        }

        public override void Quack()
        {
            Console.WriteLine("Quack");
        }

        public override void Swim()
        {
            Console.WriteLine("Swim");
        }
    }
}
