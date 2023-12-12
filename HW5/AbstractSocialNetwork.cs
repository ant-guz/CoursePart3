using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HW5
{
    public abstract class AbstractSocialNetwork
    {
        private string _login;
        public string Login
        {
            get => _login;
            set => _login = value;
        }
        private string _password;
        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public AbstractSocialNetwork(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public virtual void CreatePost(string message)
        {
            bool loginSuccessfully = LogIn(_login, _password);
            if (loginSuccessfully)
            {
                Publish(message);
                LogOut();
            }
        }

        public abstract void Publish(string message);
        public abstract void LogOut();
        public abstract bool LogIn(string login, string password);
    }
}
