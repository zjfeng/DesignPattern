using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.创建者模式
{
    internal class EmailMessage
    {
        private readonly string _to;
        private readonly string _subject;

        private readonly string _cc;
        private readonly string _bcc;
        private readonly string _body;
        private readonly bool _isHtml;
        private readonly string _priority;
        private readonly List<string> _attachments;

        public EmailMessage(string to, string subject, string cc, string bcc, string body, bool isHtml, string priority, List<string> attachments)
        {
            _to = to;
            _subject = subject;

            _cc = cc;
            _bcc = bcc;
            _body = body;
            _isHtml = isHtml;
            _priority = priority;
            _attachments = attachments;
        }
    }
}