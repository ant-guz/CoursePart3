using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    public class X : AbstractSocialNetwork
    {
        public X(string login, string password) : base(login, password)
        {
        }

        public override bool LogIn(string login, string password)
        {
            Console.WriteLine($"Successfully login into X");
            return true;
        }

        public override void LogOut()
        {
            Console.WriteLine($"Successfully logout from X");
        }

        public override void Publish(string message)
        {
            Console.WriteLine($"Successfully publish a X message: {message}");
        }
    }
}
