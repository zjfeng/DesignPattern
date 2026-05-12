using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class CombinedStrategy : IAccountingStrategy
    {
        private IList<IAccountingStrategy> strategies;

        /// <summary>
        /// 组合策略
        /// </summary>
        /// <param name="strategies"></param>
        public CombinedStrategy(IList<IAccountingStrategy> strategies)
        {
            this.strategies = strategies;
        }

        public decimal Calculate(decimal orderFee)
        {
            Console.WriteLine("调用 CombinedStrategy: 组合策略计算订单费用");
            foreach (var strategy in strategies)
            {
                orderFee = strategy.Calculate(orderFee);
            }

            return orderFee;
        }

        public bool IsApplicable() => strategies.Any();
    }
}
