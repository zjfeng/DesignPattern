using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class DiscountStrategy : IAccountingStrategy
    {
        private decimal discountRate;
        private MembershipGrade grade;

        /// <summary>
        /// 折扣策略
        /// </summary>
        /// <param name="membershipGrade"></param>
        public DiscountStrategy(MembershipGrade membershipGrade)
        {
            this.discountRate = membershipGrade switch
            {
                MembershipGrade.none => 1.0m,
                MembershipGrade.silver => 0.9m,
                MembershipGrade.gold => 0.8m,
                MembershipGrade.platinum => 0.7m,
                _ => 1.0m
            };
            this.grade = membershipGrade;
        }

        /// <summary>
        /// 打折
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        public decimal Calculate(decimal orderFee) {
            Console.WriteLine("调用打折策略，会员等级为：" + discountRate);
            return orderFee * discountRate;
        }

        public bool IsApplicable() => grade != MembershipGrade.none;
    }

    enum MembershipGrade
    { 
        none,
        silver,
        gold,
        platinum
    }
}
