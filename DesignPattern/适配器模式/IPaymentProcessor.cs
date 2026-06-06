using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.适配器模式
{
    internal interface IPaymentProcessor
    {
        public bool ProcessPayment(decimal amount);
    }
}
