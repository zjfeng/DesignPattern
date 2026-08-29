using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.状态模式
{
    internal interface IDocumentState
    {
        public OperationResult Public();
        public OperationResult Edit(string content);
        public OperationResult Delete();
    }
}
