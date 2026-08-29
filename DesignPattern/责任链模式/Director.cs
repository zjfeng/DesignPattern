using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.责任链模式
{
    internal class Director : IApprover
    {
        private IApprover _next;

        public IApprover SetNext(IApprover approver)
        {
            _next = approver;
            return _next;
        }

        public void Approve(decimal amount)
        {
            Console.WriteLine("<Director>");
            if (amount <= 10000)
            {
                Console.WriteLine("Director approve");
                return;
            }

            if (_next != null)
                _next.Approve(amount);
        }
    }
}
