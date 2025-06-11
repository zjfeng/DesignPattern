using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰者模式
{
    internal class Milk : CondimentDecorator
    {
        public Beverage Beverage { get; set; }

        public Milk(Beverage beverage) {
            Beverage = beverage;
            Beverage.Description.Insert(0, beverage.Size.ToString());
            Beverage.Description.Add("牛奶");
            Description = Beverage.Description;
            Size = Beverage.Size;
        }
        public override decimal Cost() {
            decimal cost = Beverage.Cost() + Beverage.SizeCost[(int)Size] + 0.5M;
            return cost;
        }
    }
}
