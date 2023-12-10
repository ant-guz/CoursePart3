using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Bricklayer : AbstractWorker
    {
        public override string DoWork(string request)
        {
            string result = string.Empty;
            if (request =="Build the walls")
            {
                result = $"The Bricklayer executed a request: {request}";
            }
            else
            {
                result = base.DoWork(request);
            }
            //Console.WriteLine($"Finish DoWork of Bricklayer with result: {result}");
            return result;
        }
    }
}
