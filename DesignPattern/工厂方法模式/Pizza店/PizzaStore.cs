using DesignPattern.工厂方法模式.Pizza店.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店
{
    internal class PizzaStore
    {
        private SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }

        public void OrderPizza(string type)
        {
            Pizza.Pizza pizza = factory.CreatePizza(type);
            if (pizza == null)
            {
                Console.WriteLine("没有这种类型的披萨");
                return;
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
