namespace DesignPattern.观察者模式2
{
    public class CurrentConditionsDisplay : IObserver
    {
        public WeatherData weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData; 
            weatherData.Register(this);
        }

        public void Update()
        {
            float temperature = weatherData.GetTemperature();
            float humidity = weatherData.GetHumidity();
            Display(temperature, humidity);
        }

        public void Display(float temperature, float humidity)
        {
            Console.WriteLine($"当前温度：{temperature}°C，当前湿度：{humidity}%");
        }
    }
}