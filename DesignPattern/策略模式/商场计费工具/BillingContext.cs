using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    internal class BillingContext
    {
        BillingStrategy strategy = null;

        public BillingContext(string type)
        {
            switch (type)
            { 
                case "正常收费":
                    strategy = new DiscountStrategy(1);
                    break;
                case "打8折":
                    strategy = new DiscountStrategy(0.8m);
                    break;
                case "满300返100":
                    strategy = new ReturnStrategy(300, 100);
                    break;
                default: throw new ArgumentException("无效的计费类型");
            }
        }

        public decimal GetResult(decimal amount)
        {
            return strategy.Execute(amount);
        }
    }
}
