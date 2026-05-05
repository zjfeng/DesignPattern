using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式.QQ秀
{
    internal class Person
    {
        public List<Clothing> _clothings = new List<Clothing>();
        public int index = 0;

        public string name { get; set; }

        public Person(string name)
        {
            this.name = name;
        }

        public Person() { }

        public void Wear(Clothing clothing)
        {
            _clothings.Add(clothing);
        }


        public virtual void Show()
        {
            Console.WriteLine("的装扮");
            foreach (var clothing in _clothings)
            {
                clothing.Show();
            }
        }
    }
}
