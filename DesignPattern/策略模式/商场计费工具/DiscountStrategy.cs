using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    internal class DiscountStrategy : BillingStrategy
    {
        public decimal _discount;

        public DiscountStrategy(decimal discount)
        {
            _discount = discount;
        }

        public override decimal Execute(decimal amount)
        {
            Console.WriteLine($"打折收费，折扣为{_discount * 100}%");
            
            return _discount * amount;
        }
    }
}
