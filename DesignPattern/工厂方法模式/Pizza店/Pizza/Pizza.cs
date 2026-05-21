using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店.Pizza
{
    internal abstract class Pizza
    {
        public abstract void Prepare();

        public abstract void Bake();

        public abstract void Cut();

        public abstract void Box();
    }
}
