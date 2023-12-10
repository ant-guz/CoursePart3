using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string work1 = "Design a house";
            string work2 = "Build the walls";
            string work3 = "Make a roof";
            string work4 = "Paste the wallpaper";
            Designer designer = new Designer();
            Bricklayer bricklayer = new Bricklayer();
            Carpenter carpenter = new Carpenter();
            FinishingWorker worker = new FinishingWorker();

            designer.SetNextWorker(bricklayer).SetNextWorker(carpenter).SetNextWorker(worker);
            GiveRequest(designer, work1);
            GiveRequest(designer, work2);
            GiveRequest(designer, work3);
            GiveRequest(designer, work4);


            GiveRequest(designer, "Make the windows");

        }

        public static void GiveRequest(IWorker worker, string request) 
        {
            string executeResult = worker.DoWork(request);
            if(executeResult.Equals(string.Empty))
            {
                Console.WriteLine($"Nobody can execute command: {request}");
            }
            else
            {
                Console.WriteLine(executeResult);
            }
        }
    }
}
