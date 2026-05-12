using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class OriginalPriceStrategy : IAccountingStrategy
    {
        /// <summary>
        /// 原价
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public decimal Calculate(decimal orderFee)
        {
            Console.WriteLine("调用原价策略，订单总价为：" + orderFee);
            return orderFee;
        }

        public bool IsApplicable() => true;
    }
}
