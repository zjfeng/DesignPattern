using DesignPattern.装饰者模式;
using DesignPattern.观察者模式;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var mallardDuck = new MallardDuck();
            mallardDuck.SetFlyBehavior(new FlyWithWings());
            mallardDuck.Fly();

            var redHeadDuck = new RedHeadDuck();
            redHeadDuck.Fly();

            redHeadDuck.SetFlyBehavior(new FlyRocketPowered());
            redHeadDuck.Fly();

            Console.WriteLine("=================================");

            var weatherData = new WeatherData();
            var currentDisplay = new CurrentDisplay(weatherData);
            weatherData.MeasurementChanged(); 

            weatherData.DeleteObserver(currentDisplay);

            Console.WriteLine("=================================");
            var b = new DarkRoast(Size.S);
            Console.WriteLine($"{string.Join("，", b.CountAndFormatStrings(b.Description))}，${b.Cost()}");

            Beverage b1 = new DarkRoast(Size.M);
            b1 = new Milk(b1);
            Console.WriteLine($"{string.Join("，", b1.CountAndFormatStrings(b1.Description))}，${b1.Cost()}");

            Beverage b2 = new DarkRoast(Size.L);
            b2 = new Milk(b2);
            b2 = new Milk(b2);
            Console.WriteLine($"{string.Join("，", b2.CountAndFormatStrings(b2.Description))}，${b2.Cost()}");

            Beverage b3 = new DarkRoast(Size.S);
            b3 = new Milk(b3);
            b3 = new Milk(b3);
            Console.WriteLine($"{string.Join("，", b3.CountAndFormatStrings(b3.Description))}，${b3.Cost()}");
        }
    }
}
