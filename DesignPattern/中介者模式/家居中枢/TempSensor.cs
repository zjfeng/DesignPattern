using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式.家居中枢
{
    internal class TempSensor : Instrument
    {
        private Mediator _mediator;

        public TempSensor(Mediator mediator) { 
            _mediator = mediator;
        }

        async public void GetTemperature()
        {
            Random random = new Random();

            int temp = random.Next(10, 40);
            _mediator.Notify(this, temp);
        }

        public override void TurnOff()
        {
            throw new NotImplementedException();
        }

        public override void TurnOn()
        {
            throw new NotImplementedException();
        }
    }
}
