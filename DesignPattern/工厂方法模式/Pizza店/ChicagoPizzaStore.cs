using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式.Pizza店
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza.Pizza CreatePizza(string type)
        {
            return type switch
            {
                "CheesePizza" => new Pizza.ChicagoCheesePizza(),
                "GreekPizza" => new Pizza.ChicagoGreekPizza(),
                _ => null,
            };
        }
    }
}
