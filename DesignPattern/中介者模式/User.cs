using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式
{
    internal class User(string name)
    {
        public string Name = name;

        public void ReceiveMessage(string message, User user)
        {
            Console.WriteLine($"{Name} received message : {message} from user : {user.Name}");
        }
    }
}
