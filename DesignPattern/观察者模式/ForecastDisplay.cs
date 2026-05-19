using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class ForecastDisplay : IObserver
    {
        public ISubject Subject;

        public ForecastDisplay(ISubject subject)
        {
            Subject = subject;
            Subject.RegisterObserver(this);
        }

        public void Display(float temperature, float humidity, float pressure)
        {
            Random random = new Random();
            Console.WriteLine($"预测明天气温：{temperature + random.Next(0, 5)}，湿度：{humidity + random.Next(0, 5)}%，气压：{pressure + random.Next(0, 5)}");
        }

        public void Update()
        {
            if (Subject is WeatherData weatherData)
            {
                var temperature = weatherData.GetTemperatures(1).FirstOrDefault();
                var humidity = weatherData.GetHumidities(1).FirstOrDefault();
                var pressure = weatherData.GetPressures(1).FirstOrDefault();
                Display(temperature, humidity, pressure);
            }
        }
    }
}
