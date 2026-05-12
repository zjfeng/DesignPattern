using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class FullReductionStrategy : IAccountingStrategy
    {
        private decimal fullReductionAmount;
        private decimal fullReductionFactor;

        public FullReductionStrategy(decimal amount, decimal factor) 
        {
            fullReductionAmount = amount;
            fullReductionFactor = factor;
        }

        /// <summary>
        /// 满减
        /// </summary>
        /// <param name="orderFee"></param>
        /// <returns></returns>
        public decimal Calculate(decimal orderFee)
        {
            if (orderFee >= fullReductionAmount)
            {
                Console.WriteLine("调用满减策略，满" + fullReductionAmount + "减" + fullReductionFactor);
                orderFee -= fullReductionFactor;
            }
            return orderFee;
        }

        public bool IsApplicable() => 0 < fullReductionAmount && fullReductionFactor > 0;
    }
}
