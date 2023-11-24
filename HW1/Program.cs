using System;
using System.Xml.Linq;

namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START!!!!");
            int[] resultArray = GenerateRandomIntArray(10);

            var FindStaticElementRes = FindStaticElement(resultArray, 25);
            Console.WriteLine($"FindStaticElementRes = {FindStaticElementRes}");

            var FindMaxElementRes = FindMaxElement(resultArray);
            Console.WriteLine($"FindMaxElementRes = {FindMaxElementRes}");
            int target = resultArray[5];
            var GoldenSectionSearchRes = GoldenSectionSearch(resultArray, target);
            if (GoldenSectionSearchRes != -1)
            {
                Console.WriteLine($"The element {target} is at index {GoldenSectionSearchRes}.");
            }
            else
            {
                Console.WriteLine($"The element {target} is not in the array.");
            }
        }


        static int[] GenerateRandomIntArray(int size)
        {
            Random random = new Random();
            int[] newArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                newArray[i] = random.Next(101);
            }

            return newArray;
        }

        static int FindStaticElement(int[] Array, int indexOfElement)
        {
            int result = -1;
            int numberOfElements = Array.Length - 1;

            if (numberOfElements >= indexOfElement && indexOfElement >= 0)
            {
                result = Array[indexOfElement];
            }
            return result;
        }

        static int FindMaxElement(int[] Array)
        {
            int maxElement = Array[0];

            for (int i = 0; i < Array.Length - 1; i++)
            {
                if (Array[i] > maxElement)
                {
                    maxElement = Array[i];
                }
            }

            return maxElement;
        }

        static int GoldenSectionSearch(int[] Array, int targetElement)
        {
            Console.WriteLine($"Start method GoldenSectionSearch. Find target = {targetElement}");
            Console.WriteLine($"Array = ");
            foreach (var item in Array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");

            int result = -1;
            int low = 0;
            int high = Array.Length - 1;

            double phi = (1 + Math.Sqrt(5)) / 2; //

            while (low <= high)
            {
                int part1 = (int)(high - (high - low) / phi);
                int part2 = (int)(low + (high - low) / phi);

                if (Array[part1] == targetElement)
                {
                    return part1;
                }
                else if (Array[part2] == targetElement)
                {
                    return part2;
                }
                else if (Array[part1] > targetElement)
                {
                    high = part1 - 1;
                }
                else if (Array[part2] < targetElement)
                {
                    low = part2 + 1;
                }
                else
                {
                    low = part1 + 1;
                    high = part2 - 1;
                }
            }
            Console.WriteLine($"Array 2 = ");
            foreach (var item in Array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            return result;
        }
    }
}
