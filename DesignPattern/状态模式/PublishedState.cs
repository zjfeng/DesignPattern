using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.状态模式
{
    internal class PublishedState : IDocumentState
    {
        private Document _document;
        public PublishedState(Document document)
        {
            _document = document;
        }
        public OperationResult Delete()
        {
            Console.WriteLine("已发布，不能删除");
            return OperationResult.Null;
        }

        public OperationResult Edit(string content)
        {
            Console.WriteLine("已发布，不能编辑");
            return OperationResult.Null;
        }

        public OperationResult Public()
        {
            Console.WriteLine("已发布，不能重复发布");
            return OperationResult.Null;
        }
    }
}
