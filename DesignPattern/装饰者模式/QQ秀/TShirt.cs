using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式.QQ秀
{
    internal class TShirt : Clothing
    {
        public override void Show()
        {
            Console.Write("T恤 ");
            base.Show();
        }
    }
}
