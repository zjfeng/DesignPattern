using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.创建者模式
{
    internal class Builder
    {
        private readonly string _to;
        private readonly string _subject;

        public string _cc { get; set; }
        public string _bcc { get; set; }
        public string _body { get; set; }
        public bool _isHtml { get; set; } = true;
        public string _priority { get; set; } = "Normal";
        public List<string> _attachments { get; set; }

        public Builder(string to, string subject)
        {
            _to = to;
            _subject = subject;
        }

        public EmailMessage Build()
        {
            return new EmailMessage(_to, _subject, _cc, _bcc, _body, _isHtml, _priority, _attachments);
        }
    }
}
