using DesignPattern.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.命令模式
{
    internal class CommandPatternDemo : DemoRunner
    {
        public override string Description => "Command Pattern - Remote Control";

        public override void Excute()
        {
            RemoteControl control = new RemoteControl();
            Light light = new Light();
            control.PressButton(new LightOnCommand(light));
            control.Undo();
            control.Undo();
            control.PressButton(new LightOffCommand(light));
            control.Undo();

            AirCondition airCondition = new AirCondition();
            Curtain curtain = new Curtain();

            AirConditionSetCommand airConditionSetCommand = new AirConditionSetCommand(airCondition);
            airConditionSetCommand.SetTemperature(29);

            IList<ICommand> commands = new List<ICommand> { new LightOnCommand(light), new AirConditionOnCommand(airCondition), airConditionSetCommand, new CurtainOnCommand(curtain) };
            MacroCommand macroCommand = new MacroCommand(commands);
            control.PressButton(macroCommand);
            control.Undo();
        }
    }
}
