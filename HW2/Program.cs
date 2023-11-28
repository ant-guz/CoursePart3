using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START!!!!");
            int[] resultArray = GenerateRandomIntArray(100000);
            var testArray1 = resultArray;
            var testArray2 = resultArray;
            var testArray3 = resultArray;
            //Console.WriteLine("Unsorted array:");
            //PrintArray(testArray1);
            Console.WriteLine("");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            ShakerSort(testArray1);
            Console.WriteLine("ShakerSort: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            //Console.WriteLine("Array after sort:");
            //PrintArray(testArray1);
            stopwatch.Start();
            MSDSort(testArray2, 0, testArray2.Length - 1, GetMaxDigits(testArray2));
            Console.WriteLine("MSDSort: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();

            stopwatch.Start();
            QuickSort(testArray3, 0, testArray3.Length - 1);
            Console.WriteLine("QuickSort: " + stopwatch.ElapsedMilliseconds.ToString());
            stopwatch.Reset();
        }

        static void ShakerSort(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                var swapFlag = false;
                //from left to right
                for (int j = i; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1]) 
                    {
                        var temp = 0;
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapFlag = true;
                    }
                }

                //from right to left
                for (int j = array.Length - 2 - i; j > i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        var temp = 0;
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

        }
        static void MSDSort(int[] array, int low, int high, int maxDigits)
        {
            if (low < high && maxDigits > 0)
            {
                int[] count = new int[10];
                int[] tempArray = new int[high - low + 1];

                int divisor = (int)Math.Pow(10, maxDigits - 1);

                for (int i = low; i <= high; i++)
                {
                    int digit = (array[i] / divisor) % 10;
                    count[digit]++;
                }

                for (int r = 0; r < 9; r++)
                {
                    count[r + 1] += count[r];
                }

                for (int i = high; i >= low; i--)
                {
                    int digit = (array[i] / divisor) % 10;
                    tempArray[--count[digit]] = array[i];
                }

                for (int i = low, j = 0; i <= high; i++, j++)
                {
                    array[i] = tempArray[j];
                }

                for (int r = 0; r < 10; r++)
                {
                    int newLow = low + count[r];
                    int newHigh = (r < 9) ? (low + count[r + 1] - 1) : high;
                    MSDSort(array, newLow, newHigh, maxDigits - 1);
                }
            }
        }

        static int GetMaxDigits(int[] array)
        {
            int maxDigits = 0;
            foreach (var num in array)
            {
                int currentDigits = (int)Math.Floor(Math.Log10(num) + 1);
                maxDigits = Math.Max(maxDigits, currentDigits);
            }
            return maxDigits;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Получаем индекс опорного элемента
                int pivotIndex = Partition(array, low, high);

                // Рекурсивно сортируем подмассивы до и после опорного элемента
                QuickSort(array, low, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            var temp1 = array[i + 1];
            array[i+1] = array[high];
            array[high] = temp1;

            // Возвращаем индекс опорного элемента
            return i + 1;
        }
        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
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
    }
}
