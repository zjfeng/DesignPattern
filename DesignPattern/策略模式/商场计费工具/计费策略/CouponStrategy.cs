using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class CouponStrategy : IAccountingStrategy
    {
        private decimal couponAmount;

        /// <summary>
        /// 优惠券策略
        /// </summary>
        /// <param name="couponAmount"></param>
        public CouponStrategy(decimal couponAmount)
        {
            this.couponAmount = couponAmount;
        }

        public decimal Calculate(decimal orderFee)
        {
            Console.WriteLine("调用优惠券策略，优惠券金额为：" + couponAmount);
            return Math.Max(0, orderFee - couponAmount);
        }

        public bool IsApplicable() => couponAmount > 0;
    }
}
