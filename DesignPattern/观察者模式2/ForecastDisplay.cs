namespace DesignPattern.观察者模式2
{
    public class ForecastDisplay : IObserver
    {

        public ISubject<IObserver> Subject;

        public ForecastDisplay(ISubject<IObserver> subject)
        {
            this.Subject = subject;
            subject.Register(this);
        }

        public void Update()
        {
            if (Subject is WeatherData weatherData)
            {
                Random random = new Random();
                float temperature = weatherData.GetTemperature() + random.Next(-5, 5);
                float humidity = weatherData.GetHumidity() + random.Next(-5, 5);
                float pressure = weatherData.GetPressure() + random.Next(-5, 5);
                Display(temperature, humidity, pressure);
            }
            else
            {
                Console.WriteLine("无法获取天气数据");
            }            
        }

        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"预测温度：{temperature}°C，预测湿度：{humidity}%，预测气压：{pressure}hPa");
        }
    }
}