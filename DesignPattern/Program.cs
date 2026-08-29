namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Base.Test.Run(new DesignPattern.策略模式.Duck.StrategyPatternDemo());
            //Base.Test.Run(new DesignPattern.策略模式.商场计费工具.StrategyPatternDemo());
            //Base.Test.Run(new DesignPattern.装饰器模式.咖啡店.DecoratorPatternDemo());
            //Base.Test.Run(new DesignPattern.观察者模式.ObserverPatternDemo());
            //Base.Test.Run(new DesignPattern.观察者模式2.ObserverPatternDemo());
            //Base.Test.Run(new DesignPattern.工厂方法模式.Pizza店.FactoryMethodPatternDemo());
            //Base.Test.Run(new DesignPattern.工厂方法模式.Logger.FactoryMethodPatternDemo());
            //Base.Test.Run(new DesignPattern.装饰器模式.Notifier.DecoratorPatternDemo());
            //Base.Test.Run(new DesignPattern.命令模式.CommandPatternDemo());
            //Base.Test.Run(new DesignPattern.适配器模式.AdapterPatternDemo());
            //Base.Test.Run(new DesignPattern.中介者模式.MediatorPatternDemo());
            //Base.Test.Run(new DesignPattern.代理模式.ProxyPatternDemo());
            //Base.Test.Run(new DesignPattern.责任链模式.ResponsibilityChainPatternDemo());
            //Base.Test.Run(new DesignPattern.组合模式.CombinationPatternDemo());

            A a = new A();
            a._a = "1";
            a.aa(a);
            Console.WriteLine(a._a);

            Console.ReadKey();
        }
    }

    internal class A
    {
        public string _a { get; set; }

        public void a()
        {
            Console.WriteLine("aaa");
        }

        public async Task<string> xxAsync()
        {
            Console.WriteLine("开始下载");

            // 遇到 await：线程立刻返回给调用者，不在这死等
            // 等下载完成后，再回来继续执行后面的代码
            string data = await xxAsync2();
            Console.WriteLine("下载完成1");
            // 这一步在下载完成后执行
            return $"下载完成：{data.Length} 字节";
        }

        public async Task<string> xxAsync2()
        {
            Thread.Sleep(2000);
            Console.WriteLine("下载完成");
            // 这一步在下载完成后执行
            return $"耗时2s，下载完成";
        }

        public void xx(ref string xx)
        {
            Console.WriteLine(xx);
            xx = "2";
        }

        public void xxx(out string xxx)
        {
            xxx = "3";
            Console.WriteLine(xxx);
        }

        public void x() {
            string x = "null";
            xxx(out x);
            Console.WriteLine(x);
        }

        public void aa(A aa)
        {
            aa._a = "123";
        }
    }
}
