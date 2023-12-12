using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            AbstractSocialNetwork x = new X("login1","pass2");
            x.CreatePost("Hello, X");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine();
            AbstractSocialNetwork facebook = new Facebook("login 2", "pass3");
            facebook.CreatePost("Hello, Facebook");
            Console.WriteLine($"---------------------------------------------");
            Console.WriteLine();
            Instagram insta = new Instagram("login 5", "pass5");
            insta.CreatePost("Hello, Instagram");
        }
    }
}
