using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.组合模式
{
    internal class CombinationPatternDemo : DemoRunner
    {
        public override string Description => "组合模式";

        public override void Excute()
        {
            Soldier soldier1 = new Soldier("1", 1100);
            Soldier soldier2 = new Soldier("2", 1400);
            Soldier soldier3 = new Soldier("3", 1200);
            Soldier soldier4 = new Soldier("4", 1300);

            List<IUnit> soldiers = new List<IUnit> { soldier1, soldier2, soldier3, soldier4 };

            Squad squad = new Squad("1连", soldiers);

            Console.WriteLine($"士兵 {soldier1.Name} 薪资：{soldier1.GetTotalSalary()}");
            Console.WriteLine($"士兵 {soldier2.Name} 薪资：{soldier2.GetTotalSalary()}");
            Console.WriteLine($"士兵 {soldier3.Name} 薪资：{soldier3.GetTotalSalary()}");
            Console.WriteLine($"士兵 {soldier4.Name} 薪资：{soldier4.GetTotalSalary()}");

            Console.WriteLine($"连队 {squad.Name} 薪资：{squad.GetTotalSalary()}");
        }
    }
}
