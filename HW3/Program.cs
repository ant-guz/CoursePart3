using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new Builder();
            director.Builder = builder;
            Console.WriteLine("BuildHouseWithGarden: ");
            director.BuildHouseWithGarden();
            Console.WriteLine(builder.GetHouse().ListOfDetails());

            Console.WriteLine("BuildHouseWithGarage: ");
            director.BuildHouseWithGarage();
            Console.WriteLine(builder.GetHouse().ListOfDetails());

            Console.WriteLine("BuildHouseWithoutRoof: ");
            builder.BuildFoundation();
            builder.BuildWalls();
            builder.BuildWindows();
            Console.WriteLine(builder.GetHouse().ListOfDetails());
        }
    }
}
