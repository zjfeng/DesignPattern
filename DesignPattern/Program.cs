using DesignPattern.代理模式;
using DesignPattern.初入设计模式;
using DesignPattern.工厂方法模式;
using DesignPattern.策略模式.商场计费工具;
using DesignPattern.装饰者模式;
using DesignPattern.装饰者模式.QQ秀;
using DesignPattern.观察者模式;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Calculater.Calculate();
            //ShopCalculater.Calculate();

            //ProxyPattern.Test();
            //FactoryMethodPattern.Test();
        }
    }
}
