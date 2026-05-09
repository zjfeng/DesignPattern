using DesignPattern.Base;
using DesignPattern.策略模式.商场计费工具.计费策略;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    internal class StrategyPatternDemo : DemoRunner
    {
        public override string Description => "Running Demo: 策略模式.商场计费工具";

        public override void Run()
        {
            Console.WriteLine(Description);

            Order order = new Order();
            order.Commodities.Add(new Commodity() { Name = "商品1", Price = 100 });
            order.Commodities.Add(new Commodity() { Name = "商品2", Price = 200 });
            order.CalculateTotal(new 策略模式.商场计费工具.计费策略.OriginalPriceStrategy());
            order.CalculateTotal(new 策略模式.商场计费工具.计费策略.DiscountStrategy());
            order.CalculateTotal(new 策略模式.商场计费工具.计费策略.FullReductionStrategy());
        }
    }
}
