using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店
{
    internal class NYPizzaStore : PizzaStore
    {
        public override Pizza.Pizza CreatePizza(string type)
        {
            return type switch
            {
                "CheesePizza" => new Pizza.NYCheesePizza(),
                "GreekPizza" => new Pizza.NYGreekPizza(),
                _ => null,
            };
        }
    }
}
