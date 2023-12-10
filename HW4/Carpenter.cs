using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Carpenter : AbstractWorker
    {
        public override string DoWork(string request)
        {
            string result = string.Empty;
            if (request == "Make a roof")
            {
                result = $"The Carpenter executed a request: {request}";
            } else
            {
                result = base.DoWork(request);
            }
            //Console.WriteLine($"Finish DoWork of Carpenter with result: {result}");
            return result;
        }
    }
}
