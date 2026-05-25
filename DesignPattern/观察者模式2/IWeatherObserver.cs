using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式2
{
    public interface IWeatherObserver
    {
        public void Update(float temperature, float humidity, float pressure);
    }
}
