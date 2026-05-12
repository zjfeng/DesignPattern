using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal class TimeDiscountStrategy : IAccountingStrategy
    {
        private int discountTimeStart;
        private int discountTimeEnd;
        private decimal discountRate;
        private MembershipGrade membershipGrade;

        public TimeDiscountStrategy(MembershipGrade grade, int startHour, int endHour, decimal discountRate)
        {
            membershipGrade = grade;
            discountTimeStart = startHour;
            discountTimeEnd = endHour;
            this.discountRate = discountRate;
        }

        public decimal Calculate(decimal orderFee)
        {
            Console.WriteLine("调用时间段折扣策略，开始时间为：" + discountTimeStart + "，结束时间为：" + discountTimeEnd + "，折扣率为：" + discountRate);
            return orderFee * discountRate;
        }

        public bool IsApplicable() => membershipGrade != MembershipGrade.none && DateTime.Now.Hour >= discountTimeStart && DateTime.Now.Hour <= discountTimeEnd;
    }
}
