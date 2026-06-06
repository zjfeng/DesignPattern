using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式
{
    internal class StripePaymentAdapter : IPaymentProcessor
    {
        private StripeGateway _stripeGateway;
        private string _currency;

        public StripePaymentAdapter(StripeGateway stripeGateway, string currency)
        {
            _stripeGateway = stripeGateway;
            _currency = currency;
        }

        public bool ProcessPayment(decimal amount)
        {
            return _stripeGateway.Charge(amount, _currency);
        }
    }
}
