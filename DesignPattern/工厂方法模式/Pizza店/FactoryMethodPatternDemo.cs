using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店
{
    internal class FactoryMethodPatternDemo : Base.DemoRunner
    {
        public override string Description => "工厂方法模式";

        public override void Excute()
        {
            PizzaStore store = new PizzaStore(new SimplePizzaFactory());
            store.OrderPizza("CheesePizza");
        }
    }
}
