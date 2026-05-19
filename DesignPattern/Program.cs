namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Base.Test.Run(new DesignPattern.策略模式.商场计费工具.StrategyPatternDemo());
            //Base.Test.Run(new DesignPattern.装饰器模式.咖啡店.DecoratorPatternDemo());
            Base.Test.Run(new DesignPattern.观察者模式.ObserverPatternDemo());
        }
    }
}
