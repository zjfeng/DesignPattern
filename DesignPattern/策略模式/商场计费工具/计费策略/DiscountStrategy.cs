using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class DiscountStrategy : IAccountingStrategy
    {
        /// <summary>
        /// 打折
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public decimal Accounting(Order order)
        {
            return order.Commodities.Sum(x => x.Price) * 0.8m;
        }
    }
}
