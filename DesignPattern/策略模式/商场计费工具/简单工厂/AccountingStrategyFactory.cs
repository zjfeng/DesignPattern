using DesignPattern.策略模式.商场计费工具.计费策略;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.简单工厂
{
    internal class AccountingStrategyFactory
    {
        public IAccountingStrategy CreateStrategy(decimal orderFee, MembershipGrade membershipGrade, decimal couponAmount)
        {
            IList<IAccountingStrategy> strategies = new List<IAccountingStrategy> { 
                new DesignPattern.策略模式.商场计费工具.计费策略.OriginalPriceStrategy(),
                new DesignPattern.策略模式.商场计费工具.计费策略.DiscountStrategy(membershipGrade),
                new DesignPattern.策略模式.商场计费工具.计费策略.CouponStrategy(couponAmount),
                new DesignPattern.策略模式.商场计费工具.计费策略.FullReductionStrategy(300, 80),
                new DesignPattern.策略模式.商场计费工具.计费策略.TimeDiscountStrategy(membershipGrade,2, 3, 0.9m)
            };

            var applicableStrategies = strategies.Where(w => w.IsApplicable()).ToList();

            return new DesignPattern.策略模式.商场计费工具.计费策略.CombinedStrategy(applicableStrategies);
        }
    }
}
