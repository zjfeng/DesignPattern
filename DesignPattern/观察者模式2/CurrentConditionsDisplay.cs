namespace DesignPattern.观察者模式2
{
    public class CurrentConditionsDisplay : IObserver
    {
        public ISubject Subject;

        public CurrentConditionsDisplay(ISubject subject)
        {
            this.Subject = subject; 
            subject.Register(this);
        }

        public void Update()
        {
            if (Subject is WeatherData weatherData)
            {
                float temperature = weatherData.GetTemperature();
                float humidity = weatherData.GetHumidity();
                Display(temperature, humidity);
            }
            else
            {
                Console.WriteLine("无法获取天气数据");
            }
        }

        public void Display(float temperature, float humidity)
        {
            Console.WriteLine($"当前温度：{temperature}°C，当前湿度：{humidity}%");
        }
    }
}