using DesignPattern.策略模式.商场计费工具.计费策略;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    internal class Order
    {
        public IList<Commodity> Commodities = new List<Commodity>();
        public decimal Total { get; set; }

        public decimal CalculateTotal(IAccountingStrategy strategy)
        {
            Total = strategy.Calculate(this.Commodities.Sum(s => s.Price));

            Console.WriteLine("订单总价为：" + Total);

            return Total;
        }
    }
}
