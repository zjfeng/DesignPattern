using DesignPattern.工厂方法模式.Pizza店.Pizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店
{
    internal class SimplePizzaFactory
    {
        public Pizza.Pizza CreatePizza(string type)
        {
            Pizza.Pizza pizza = null;

            if (type == "CheesePizza")
            {
                pizza = new CheesePizza();
            }
            else if (type == "GreekPizza")
            {
                pizza = new GreekPizza();
            }
            else
            {
                Console.WriteLine("卖完了");
                return null;
            }

            return pizza;
        }
    }
}
