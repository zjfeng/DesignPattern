using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class StatisticsDisplay : IObserver
    {
        public ISubject Subject;

        public StatisticsDisplay(ISubject subject)
        {
            Subject = subject;
            Subject.RegisterObserver(this);
        }

        public void Display(IList<float> temperatures, IList<float> humidities, IList<float> pressures)
        {
            Console.WriteLine("平均温度：{0:F2}F", temperatures.Average());
            Console.WriteLine("平均湿度：{0:F2}%", humidities.Average());
            Console.WriteLine("平均气压：{0:F2}", pressures.Average());

            Console.WriteLine("最高温度：{0:F2}F", temperatures.Max());
            Console.WriteLine("最高湿度：{0:F2}%", humidities.Max());
            Console.WriteLine("最高气压：{0:F2}", pressures.Max());

            Console.WriteLine("最低温度：{0:F2}F", temperatures.Min());
            Console.WriteLine("最低湿度：{0:F2}%", humidities.Min());
            Console.WriteLine("最低气压：{0:F2}", pressures.Min());
        }

        public void Update()
        {
            if (Subject is WeatherData weatherData)
            {
                var temperatures = weatherData.GetTemperatures(2);
                var humidities = weatherData.GetHumidities(2);
                var pressures = weatherData.GetPressures(2);
                Display(temperatures, humidities, pressures);
            }
        }
    }
}
