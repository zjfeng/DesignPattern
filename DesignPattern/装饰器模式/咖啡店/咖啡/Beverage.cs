using DesignPattern.装饰器模式.咖啡店.调料;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.装饰器模式.咖啡店.咖啡
{
    internal abstract class Beverage
    {
        IList<Seasoning> seasoning = new List<Seasoning>();

        public string GetDescription() {
            return string.Join("，", this.seasoning.Select(s => s.GetDescription())) + GetBeverageDescription();
        }
        public decimal Cost()
        { 
            return this.seasoning.Sum(s => s.Cost()) + GetBeverageCost();
        }

        public void AddSeasoning(Seasoning s) {
            this.seasoning.Add(s);
        }

        public abstract string GetBeverageDescription();
        public abstract decimal GetBeverageCost();

    }
}
