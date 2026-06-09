using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.中介者模式
{
    internal class ChatRoom
    {
        private List<User> _users = new List<User>();

        public void SignIn(User user)
        {
            _users.Add(user);
        }

        public void Singout(User user)
        {
            _users.Remove(user);
        }

        public void SendMessage(string message, User sender)
        {
            foreach (var user in _users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message, sender);
                }
            }
        }
    }
}
