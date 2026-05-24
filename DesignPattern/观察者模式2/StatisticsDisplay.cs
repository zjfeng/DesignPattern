namespace DesignPattern.观察者模式2
{
    public class StatisticsDisplay : IObserver
    {
        public WeatherData weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Register(this);
        }

        public void Update()
        {
            float temperature = weatherData.GetTemperature();
            float humidity = weatherData.GetHumidity();
            float pressure = weatherData.GetPressure();
            Display(temperature, humidity, pressure);
        }

        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"当前温度：{temperature}°C，当前湿度：{humidity}%，当前气压：{pressure}hPa");
        }
    }
}