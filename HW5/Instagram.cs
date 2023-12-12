using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Instagram : AbstractSocialNetwork
    {
        public Instagram(string login, string password) : base(login, password)
        {
        }

        public override void CreatePost(string message)
        {
            bool loginSuccessfully = LogIn(Login, Password);
            if (loginSuccessfully)
            {
                Console.WriteLine($"----->Add picture.");
                Publish(message);
                LogOut();
            }
        }
        public override bool LogIn(string login, string password)
        {
            Console.WriteLine($"Successfully login into Instagram");
            return true;
        }

        public override void LogOut()
        {
            Console.WriteLine($"Successfully logout from Instagram");
        }

        public override void Publish(string message)
        {
            Console.WriteLine($"Successfully publish a Instagram message: {message}");
        }
    }
}
