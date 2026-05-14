using DesignPattern.Base;
using DesignPattern.装饰器模式.咖啡店.咖啡;

namespace DesignPattern.装饰器模式.咖啡店
{
    internal class DecoratorPatternDemo : DemoRunner
    {
        public override string Description => "装饰器模式.咖啡店";

        public override void Excute()
        {
            BeverageBuilder builder = new BeverageBuilder();
            builder.SetBeverage(new HouseBlend());
            builder.AddCondiment(SeasoningType.Mocha);
            builder.SetSize(SizeType.Grande);
            builder.AddCondiment(SeasoningType.SteamedMilk);
            Beverage beverage = builder.Build();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
        }
    }
}