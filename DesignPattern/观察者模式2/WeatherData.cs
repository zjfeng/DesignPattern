namespace DesignPattern.观察者模式2
{
    public class WeatherData : ISubject<IObserver>, ISubject<IWeatherObserver>, ISubject<IDataObserver>
    {
        private List<IObserver> observers = new List<IObserver>();
        private List<IWeatherObserver> weatherObservers = new List<IWeatherObserver>();
        private List<IDataObserver> dataObservers = new List<IDataObserver>();

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

            foreach (var observer in weatherObservers)
            {
                observer.Update(GetTemperature(), GetHumidity(), GetPressure());
            }

            foreach (var observer in dataObservers)
            {
                observer.Update(this);
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

        public void Register(IWeatherObserver observer)
        {
            weatherObservers.Add(observer);
        }

        public void Remove(IWeatherObserver observer)
        {
            weatherObservers.Remove(observer);
        }

        public void Register(IDataObserver observer)
        {
            dataObservers.Add(observer);
        }

        public void Remove(IDataObserver observer)
        {
            dataObservers.Remove(observer);
        }
    }
}