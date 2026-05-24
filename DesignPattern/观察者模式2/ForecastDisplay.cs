namespace DesignPattern.观察者模式2
{
    public class ForecastDisplay : IObserver
    {

        public WeatherData weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Register(this);
        }

        public void Update()
        {
            Random random = new Random();
            float temperature = weatherData.GetTemperature() + random.Next(-5, 5);
            float humidity = weatherData.GetHumidity() + random.Next(-5, 5);
            float pressure = weatherData.GetPressure() + random.Next(-5, 5);
            Display(temperature, humidity, pressure);
        }

        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"预测温度：{temperature}°C，预测湿度：{humidity}%，预测气压：{pressure}hPa");
        }

    }
}