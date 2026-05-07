using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    internal class Order
    {
        public IList<Commodity> Commodities = new List<Commodity>();
        public decimal Total { get; set; }

        public decimal CalculateTotal(DiscountType type)
        {
            switch(type)
            {
                case DiscountType.None:
                    Total = Commodities.Sum(x => x.Price);
                    break;
                case DiscountType.Percentage:
                    Total = Commodities.Sum(x => x.Price) * 0.8m;
                    break;
                case DiscountType.FixedAmount:
                    Total = Commodities.Sum(x => x.Price);
                    if (Total >= 300)
                    {
                        Total -= 50;
                    }
                    break;
            }

            Console.WriteLine("订单总价为：" + Total);

            return Total;
        }
    }

    enum DiscountType
    {
        None,
        Percentage,
        FixedAmount
    }
}
