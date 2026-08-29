using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.组合模式
{
    internal class Squad : IUnit
    {
        public string Name { get; }

        public List<IUnit> Soldiers { get; }

        public Squad(string name, List<IUnit> soldiers)
        {
            Name = name;
            Soldiers = soldiers;
        }

        public decimal GetTotalSalary()
        {
            return Soldiers.Sum(s => s.GetTotalSalary());
        }
    }
}
