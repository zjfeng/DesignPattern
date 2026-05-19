using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class CurrentConditionsDisplay : IObserver
    {
        public ISubject Subject;

        public CurrentConditionsDisplay(ISubject subject)
        {
            Subject = subject;
            Subject.RegisterObserver(this);
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

        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"当前天气：温度 {temperature}F，湿度 {humidity}%，气压 {pressure}");
        }
    }
}
