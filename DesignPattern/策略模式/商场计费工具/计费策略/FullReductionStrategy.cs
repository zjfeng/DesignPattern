using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class FullReductionStrategy : IAccountingStrategy
    {
        /// <summary>
        /// 满减
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public decimal Accounting(Order order)
        {
            decimal total = order.Commodities.Sum(x => x.Price);
            if (total >= 300)
            {
                total -= 50;
            }
            return total;
        }
    }
}
