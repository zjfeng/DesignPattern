using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式.QQ秀
{
    internal class Tie : Clothing
    {
        public override void Show()
        {
            Console.Write("领带 ");
            base.Show();
        }
    }
}
