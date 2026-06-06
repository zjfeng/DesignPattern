using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式
{
    internal class AdapterPatternDemo : DemoRunner
    {
        public override string Description => "Adapter Pattern";

        public override void Excute()
        {
            StripeGateway stripeGateway = new StripeGateway();
            StripePaymentAdapter paymentGateway = new StripePaymentAdapter(stripeGateway, "USD");

            paymentGateway.ProcessPayment(100m);

        }
    }
}
