using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.责任链模式
{
    internal interface IApprover
    {
        public void Approve(decimal amount);

        public IApprover SetNext(IApprover approver);
    }
}
