using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式2
{
    internal class CurrentDisplay : IWeatherObserver
    {
        public void Update(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"当前温度：{temperature}，当前湿度：{humidity}，当前气压：{pressure}");
        }
    }
}
