using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式.QQ秀
{
    internal class Clothing : Person
    {
        protected Person person;

        public void SetPerson(Person person)
        {
            this.person = person;
        }

        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}
