using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DesignPattern.状态模式
{
    internal class Document
    {
        private string Content { get; set; }

        private static readonly Dictionary<(Type, OperationResult), Type> _transitions = new()
{
    { (typeof(DraftState), OperationResult.Submit), typeof(ModerationState) },
    { (typeof(ModerationState), OperationResult.Published), typeof(PublishedState) },
};


        public void Show()
        {
            Console.WriteLine(Content);
        }

        private IDocumentState _documentState;

        public void ChangeState(IDocumentState state)
        {
            _documentState = state;
        }

        internal void SetContent(string content)
        {
            Content = content;
        }

        public Document()
        {
            _documentState = new DraftState(this);
        }

        private void Transition(OperationResult result)
        {
            var key = (_documentState.GetType(), result);
            if (_transitions.TryGetValue(key, out var nextType))
            {
                _documentState = (IDocumentState)Activator.CreateInstance(nextType, this);
            }
        }

        public void Public()
        {
            Transition(_documentState.Public());
        }

        public void Edit(string content)
        {
            Transition(_documentState.Edit(content));
        }

        public void Delete()
        {
            Transition(_documentState.Delete());
        }
    }

    enum OperationResult
    {
        Submit, Audit, Published, Null
    }
}
