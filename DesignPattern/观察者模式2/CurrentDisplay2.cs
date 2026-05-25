using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式2
{
    internal class CurrentDisplay2 : IDataObserver
    {
        public void Update(ISubject<IDataObserver> subject)
        {
            if (subject is WeatherData weatherData)
            {
                var temperature = weatherData.GetTemperature();
                var humidity = weatherData.GetHumidity();
                var pressure = weatherData.GetPressure();
                Console.WriteLine($"当前温度：{temperature}，当前湿度：{humidity}，当前气压：{pressure}");
            }
            else
            {
                Console.WriteLine("无数据");
            }
        }
    }
}
