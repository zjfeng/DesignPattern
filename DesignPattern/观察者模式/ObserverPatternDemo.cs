using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class ObserverPatternDemo : DemoRunner
    {
        public override string Description => "观察者模式";

        public override void Excute()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay current = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statis = new StatisticsDisplay(weatherData);
            ForecastDisplay forecast = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(25.0f, 65.0f, 1013.25f);

            weatherData.RemoveObserver(statis);
            weatherData.SetMeasurements(28.0f, 70.0f, 1012.50f);    
        }
    }
}
