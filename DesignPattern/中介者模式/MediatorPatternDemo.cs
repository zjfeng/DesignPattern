using DesignPattern.Base;
using DesignPattern.中介者模式.家居中枢;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式
{
    internal class MediatorPatternDemo : DemoRunner
    {
        public override string Description => "Mediator Pattern";

        public override void Excute()
        {
            //var chatRoom = new ChatRoom();
            //var user1 = new User("Alice");
            //var user2 = new User("Bob");
            //var user3 = new User("Charlie");

            //chatRoom.SignIn(user1);
            //chatRoom.SignIn(user2);
            //chatRoom.SignIn(user3);

            //chatRoom.SendMessage("Hello everyone!", user1);
            //chatRoom.SendMessage("Hi Alice!", user2);
            //chatRoom.SendMessage("Hey Alice and Bob!", user3);

            //chatRoom.SendMessage("Goodbye everyone!", user1);
            //chatRoom.Singout(user1);

            //chatRoom.SendMessage("Alice has left the chat.", user2);

            Mediator mediator = new Mediator();
            mediator.Instruments = new List<Instrument> { new AC(), new Light(), new Window() };

            SmokeDetector smokeDetector = new SmokeDetector(mediator);
            TempSensor tempSensor = new TempSensor(mediator);

            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();

            smokeDetector.SetIsSmokeDetected(true);

            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();

            smokeDetector.SetIsSmokeDetected(false);

            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();
            tempSensor.GetTemperature();

        }
    }
}
