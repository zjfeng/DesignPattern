using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.创建者模式
{
    internal class Director
    {
        private Builder _builder;
        private readonly string _to;
        private readonly string _subject;

        public Director(string to, string subject)
        {
            _to = to;
            _subject = subject;
        }

        public EmailMessage BuildEmail()
        {
            _builder = new Builder(_to, _subject);

            _builder._priority = "Height";
            _builder._isHtml = true;

            return _builder.Build();
        }
    }
}
