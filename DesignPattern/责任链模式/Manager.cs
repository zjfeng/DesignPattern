using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.责任链模式
{
    internal class Manager : IApprover
    {
        private IApprover _next;

        public IApprover SetNext(IApprover approver)
        {
            _next = approver;
            return _next;
        }

        public void Approve(decimal amount)
        {
            Console.WriteLine("<manager>");
            if (amount <= 1000)
            {
                Console.WriteLine("manager approve");
                return;
            }

            if (_next != null)
                _next.Approve(amount);
        }
    }
}
