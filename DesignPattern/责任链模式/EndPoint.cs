using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.责任链模式
{
    internal class EndPoint : IApprover
    {
        public void Approve(decimal amount)
        {
            Console.WriteLine("没人能处理！！");
        }

        public IApprover SetNext(IApprover approver)
        {
            throw new NotImplementedException();
        }
    }
}
