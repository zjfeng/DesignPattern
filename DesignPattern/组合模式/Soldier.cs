using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.组合模式
{
    internal class Soldier : IUnit
    {
        public string Name { get; }
        public decimal Salary { get; }

        public Soldier(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public decimal GetTotalSalary()
        {
            return Salary;
        }
    }
}
