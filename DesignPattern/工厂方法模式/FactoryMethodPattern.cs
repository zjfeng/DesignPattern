using DesignPattern.初入设计模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.工厂方法模式
{
    internal static class FactoryMethodPattern
    {
        public static void Test()
        {
            ICreateMethonFactory createMethonFactory = new CreateAddFactory();
            Methon methon = createMethonFactory.CreateMethon();
            methon.Execute(1, 2);
        }
    }
}