using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.策略模式.商场计费工具.计费策略
{
    internal interface IAccountingStrategy
    {
        public bool IsApplicable();
        public decimal Calculate(decimal orderFee);
    }
}
