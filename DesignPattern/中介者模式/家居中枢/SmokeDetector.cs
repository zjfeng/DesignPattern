using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式.家居中枢
{
    internal class SmokeDetector : Instrument
    {
        private Mediator _mediator;

        public SmokeDetector(Mediator mediator)
        {
            _mediator = mediator;
        }

        async public void SetIsSmokeDetected(bool isSmokeDetected)
        {
            _mediator.Notify(this, isSmokeDetected);
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
