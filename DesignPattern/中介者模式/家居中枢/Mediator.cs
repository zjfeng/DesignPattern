using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式.家居中枢
{
    internal class Mediator
    {
        public IList<Instrument> Instruments { get; set; } = new List<Instrument>();
        bool model = true;

        public void Notify(Instrument sender, object eventObj)
        {
            Console.WriteLine(eventObj.ToString());

            AC ac = Instruments.OfType<AC>().FirstOrDefault();
            Light light = Instruments.OfType<Light>().FirstOrDefault();
            Window window = Instruments.OfType<Window>().FirstOrDefault();

            
            if (sender is SmokeDetector detector)
            {
                bool isSmokeDetected = (bool)eventObj;
                if (isSmokeDetected)
                {
                    ac.TurnOff();
                    window.TurnOn();
                    light.TurnOn();

                    model = false;
                }
                else
                {
                    model = true;
                }
            }
            else if (sender is TempSensor && eventObj is int temp && model)
            {
                if (temp > 28)
                {
                    Console.WriteLine("temperature is too hot, close window and open AC to cold");
                    ac.TurnOn();
                    ac.SetCold();

                    window.TurnOff();
                }
                else if (temp < 18)
                {
                    Console.WriteLine("temperature is too cold, close window and open AC to hot");
                    ac.TurnOn();
                    ac.SetHot();

                    window.TurnOff();
                }
                else
                {
                    Console.WriteLine("temperature is acceptable, open window and close AC");
                    ac.TurnOff();

                    window.TurnOn();
                }
            }
        }
    }
}
