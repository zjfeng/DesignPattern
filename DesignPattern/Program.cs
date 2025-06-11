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
        }
    }
}
