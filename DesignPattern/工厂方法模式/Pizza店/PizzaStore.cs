using DesignPattern.工厂方法模式.Pizza店.Pizza;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店
{
    internal abstract class PizzaStore
    {
        public abstract Pizza.Pizza CreatePizza(string type);

        public void OrderPizza(string type)
        {
            Pizza.Pizza pizza = CreatePizza(type);
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
