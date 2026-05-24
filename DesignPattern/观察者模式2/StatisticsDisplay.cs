namespace DesignPattern.观察者模式2
{
    public class StatisticsDisplay : IObserver
    {
        public ISubject Subject;
        private List<float> temperatureReadings = new List<float>();
        private List<float> humidityReadings = new List<float>();
        private List<float> pressureReadings = new List<float>();

        public StatisticsDisplay(ISubject subject)
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
                float pressure = weatherData.GetPressure();

                // 在这里可以进行统计计算，例如计算平均值、最大值、最小值等
                temperatureReadings.Add(temperature);
                humidityReadings.Add(humidity);
                pressureReadings.Add(pressure);

                temperature = temperatureReadings.Average();
                humidity = humidityReadings.Average();
                pressure = pressureReadings.Average();

                Display(temperature, humidity, pressure);
            }
            else
            {
                Console.WriteLine("无法获取天气数据");
            }
        }

        public void Display(float temperature, float humidity, float pressure)
        {
            Console.WriteLine($"当前温度：{temperature}°C，当前湿度：{humidity}%，当前气压：{pressure}hPa");
        }
    }
}