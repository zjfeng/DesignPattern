using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class WeatherData : ISubject
    {
        private IList<IObserver> Observers = new List<IObserver>();
        public IList<float> Temperatures = new List<float>();
        public IList<float> Humidities = new List<float>();
        public IList<float> Pressures = new List<float>();

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.Temperatures.Add(temperature);
            this.Humidities.Add(humidity);
            this.Pressures.Add(pressure);
            NotifyObservers();
        }

        public void NotifyObservers()
        {
            Console.WriteLine("通知所有的观察者，天气数据发生了变化");
            foreach (var observer in Observers)
            {
                observer.Update();
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            Console.WriteLine("注册一个观察者");
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            Console.WriteLine("移除一个观察者");
            Observers.Remove(observer);
        }

        public IList<float> GetTemperatures(int count = 0)
        {
            if (count == 0)
                return Temperatures;
            return Temperatures.TakeLast(count).ToList();
        }

        public IList<float> GetHumidities(int count = 0)
        {
            if (count == 0)
                return Humidities;
            return Humidities.TakeLast(count).ToList();
        }

        public IList<float> GetPressures(int count = 0)
        {
            if (count == 0)
                return Pressures;
            return Pressures.TakeLast(count).ToList();
        }
    }
}
