using DesignPattern.装饰者模式.QQ秀;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    internal class Errand : Person, IGivePresent
    {
        public Errand(string name) : base(name)
        {
        }

        
        private Suitor suitor { get; set; }

        public void SetSuitor(Suitor suitor)
        {
            this.suitor = suitor;
        }


        public void GiveChocolate()
        {
            suitor.GiveChocolate();
        }

        public void GiveDolls()
        {
            suitor.GiveDolls();
        }

        public void GiveFlowers()
        {
            suitor.GiveFlowers();
        }
    }
}
