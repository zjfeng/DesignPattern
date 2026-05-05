using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    internal class ReturnStrategy : BillingStrategy
    {
        public decimal _condition;
        public decimal _returnCash;

        public ReturnStrategy(decimal condition, decimal returnCash)
        {
            _condition = condition;
            _returnCash = returnCash;
        }

        public override decimal Execute(decimal amount)
        {
            return amount >= _condition ? amount - _returnCash : amount;
        }
    }
}
