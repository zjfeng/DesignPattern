using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式
{
    internal class StripeGateway
    {
        public bool Charge(decimal amount, string currency)
        {
            Console.WriteLine($"Stripe 扣款: {amount} {currency}");
            return true;
        }
    }
}
