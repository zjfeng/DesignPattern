using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal class WeatherData : IObserverable<WeatherData>
    {
        public float Temperature { get; set; }
        public float Pressure { get; set; }
        public float Humidity { get; set; }
        public List<IObserver<WeatherData>> Observers { get; set; } = new List<IObserver<WeatherData>>();
        public bool Changed { get; set; } = false;

        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void AddObserver(IObserver<WeatherData> observer)
        {
            if (!Observers.Contains(observer))
            {
                Observers.Add(observer);
            }
        }

        /// <summary>
        /// 删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void DeleteObserver(IObserver<WeatherData> observer)
        {
            if (Observers.Contains(observer))
            {
                Observers.Remove(observer);
                Console.WriteLine("取消订阅者的订阅");
            }
        }

        /// <summary>
        /// 通知观察者数据有更新
        /// </summary>
        public void NotifyObservers()
        {
            if (!Changed)
            {
                return;
            }

            foreach (var observer in Observers)
            {
                observer.Update();
            }
            SetChanged();
        }

        /// <summary>
        /// 更新数据状态
        /// </summary>
        public void SetChanged()
        {
            Changed = !Changed;
        }

        /// <summary>
        /// 监测数据发生变化
        /// </summary>
        public void MeasurementChanged()
        {
            var rand = new Random();
            Temperature = (float)(rand.NextDouble() * 40 - 10); // -10°C 到 30°C
            Pressure = (float)(rand.NextDouble() * 40 + 960);   // 960hPa 到 1000hPa
            Humidity = (float)(rand.NextDouble() * 100);        // 0% 到 100%

            // 可以在此增加条件限制，满足条件才变更
            if (true)
            {
                SetChanged();
                NotifyObservers();
            }
        }
    }
}
