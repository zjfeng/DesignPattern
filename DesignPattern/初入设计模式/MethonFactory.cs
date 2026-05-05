using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.初入设计模式
{
    public static class MethonFactory
    {
        public static Methon Create(string op)
        {
            Methon methon = op switch
            {
                "+" => new Add(),
                "-" => new Subtract(),
                "*" => new Multiply(),
                "/" => new Divide(),
                _ => throw new InvalidOperationException("无效的运算符")
            };

            return methon;
        }
    }
}
