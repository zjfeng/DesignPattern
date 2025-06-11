using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface FlyBehavior
    {
        void Fly();
    }

    class FlyWithWings : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can fly with wings");
        }
    }

    class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

    class FlyRocketPowered : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!");
        }
    }
}
