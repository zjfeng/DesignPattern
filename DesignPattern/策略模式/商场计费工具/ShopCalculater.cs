using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具
{
    public static class ShopCalculater
    {
        public static void Calculate()
        {
            Console.WriteLine("请输入商品价格：");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("请输入数量");
            int count = Convert.ToInt32(Console.ReadLine());
            decimal result = 0;
            decimal amount = price * count;

            try
            {
                BillingContext context = new BillingContext("正常收费");
                result = context.GetResult(amount);
                Console.WriteLine("最终价格为{0}", result);
                context = new BillingContext("打8折");
                result = context.GetResult(amount);
                Console.WriteLine("最终价格为{0}", result);
                context = new BillingContext("满300返100");
                result = context.GetResult(amount);
                Console.WriteLine("最终价格为{0}", result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
