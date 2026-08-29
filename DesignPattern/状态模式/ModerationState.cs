using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.状态模式
{
    internal class ModerationState : IDocumentState
    {
        private Document _document;
        public ModerationState(Document document)
        {
            _document = document;
        }
        public OperationResult Delete()
        {
            Console.WriteLine("审核中，不能删除");
            return OperationResult.Null;
        }

        public OperationResult Edit(string content)
        {
            Console.WriteLine("审核中，不能编辑");
            return OperationResult.Null;
        }

        public OperationResult Public()
        {
            Console.WriteLine("发布成功");
            return OperationResult.Published;
        }
    }
}
