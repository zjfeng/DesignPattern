using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class CurrentDisplay : IObserver<WeatherData>, IDisplayElement
    {
        private WeatherData _weatherData { get; set; } 
        private float Temperature { get; set; }
        private float Humidity { get; set; }
        private float Pressure { get; set; }

        public CurrentDisplay(WeatherData weatherData) 
        {
            _weatherData = weatherData;
            weatherData.AddObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"当前信息：温度{Temperature}，湿度{Humidity}，大气压力{Pressure}");
        }

        public void Update()
        {
            Temperature = _weatherData.Temperature;
            Humidity = _weatherData.Humidity;
            Pressure = _weatherData.Pressure;
            Display();
        }
    }
}
