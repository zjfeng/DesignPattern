using DesignPattern.Base;

namespace DesignPattern.观察者模式2
{
    internal class ObserverPatternDemo : DemoRunner
    {
        public override string Description => "观察者模式2";

        public override void Excute()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.MeasurementsChanged();

            weatherData.Remove(statisticsDisplay);
            weatherData.MeasurementsChanged();

            Console.WriteLine("push");
            CurrentDisplay currentDisplay = new CurrentDisplay();
            weatherData.Register(currentDisplay);
            weatherData.MeasurementsChanged();

            Console.WriteLine("pull");
            CurrentDisplay2 currentDisplay2 = new CurrentDisplay2();
            weatherData.Register(currentDisplay2);
            weatherData.MeasurementsChanged();
        }
    }
}