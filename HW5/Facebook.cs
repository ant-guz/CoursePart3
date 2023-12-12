using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class Facebook : AbstractSocialNetwork
    {
        public Facebook(string login, string password) : base(login, password)
        {
        }

        public override bool LogIn(string login, string password)
        {
            Console.WriteLine($"Successfully login into Facebook");
            return true;
        }

        public override void LogOut()
        {
            Console.WriteLine($"Successfully logout from Facebook");
        }

        public override void Publish(string message)
        {
            Console.WriteLine($"Successfully publish a Facebook message: {message}");
        }
    }
}
