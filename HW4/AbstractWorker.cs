using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    abstract class AbstractWorker : IWorker
    {
        private IWorker nextWorker;
        public AbstractWorker() => nextWorker = null;
        public IWorker SetNextWorker(IWorker worker)
        {
            nextWorker = worker;
            return worker;
        }
        public virtual string DoWork(string request)
        {
            if (nextWorker != null)
            {
                return nextWorker.DoWork(request);
            }
            else {
                return string.Empty;
            }
                
           
        }

        
    }
}
