using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class Designer : AbstractWorker
    {
        public override string DoWork(string request)
        {
            string result = string.Empty;
            if (request == "Design a house")
            { 
                result = $"The Designer executed a request: {request}"; 
            }
            else 
            { 
                result = base.DoWork(request); 
            }
            //Console.WriteLine($"Finish DoWork of Designer with result: {result}");
            return result;
        }
    }
}
