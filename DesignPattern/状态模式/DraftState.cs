using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.状态模式
{
    internal class DraftState : IDocumentState
    {
        private Document _document;
        public DraftState(Document document)
        {
            _document = document;
        }
        public OperationResult Delete()
        {
            Console.WriteLine("已删除");
            return OperationResult.Null;
        }

        public OperationResult Edit(string content)
        {
            Console.WriteLine("可编辑");
            _document.SetContent(content);
            return OperationResult.Null;
        }

        public OperationResult Public()
        {
            Console.WriteLine("提交审核");
            return OperationResult.Submit;
        }
    }
}
