using DesignPattern.初入设计模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式
{
    internal class CreateAddFactory : ICreateMethonFactory
    {
        public Methon CreateMethon()
        {
            return new Add();
        }
    }
}
