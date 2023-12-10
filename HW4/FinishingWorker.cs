using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    class FinishingWorker : AbstractWorker
    {
        public override string DoWork(string request)
        {
            string result = string.Empty;
            if (request == "Paste the wallpaper")
            {
                result = $"The FinishingWorker executed the request: {request}";

            }
            else
            {
                result = base.DoWork(request);
            }
            //Console.WriteLine($"Finish DoWork of FinishingWorker with result: {result}");

            return result;
        }
    }
}
