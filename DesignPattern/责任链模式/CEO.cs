using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.责任链模式
{
    internal class CEO : IApprover
    {
        private IApprover _next;
        public void Approve(decimal amount)
        {
            Console.WriteLine("<CEO>");
            if (amount > 10000)
            {
                Console.WriteLine("CEO approve");
                return;
            }

            if (_next != null)
                _next.Approve(amount);
        }

        public IApprover SetNext(IApprover approver)
        {
            _next = approver;
            return _next;
        }
    }
}
