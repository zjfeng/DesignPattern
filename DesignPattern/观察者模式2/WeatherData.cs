namespace DesignPattern.观察者模式2
{
    public class WeatherData
    {
        private List<IObserver> observers = new List<IObserver>();

        public float GetTemperature() => new Random().Next(0, 100);
        public float GetHumidity() => new Random().Next(0, 100);
        public float GetPressure() => new Random().Next(0, 100);

        public void MeasurementsChanged()
        {
            Notify();
        }

        public void Notify()
        {
            foreach (var observer in observers)
            {
                observer.Update();
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}