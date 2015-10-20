//Joshua Pickenpaugh, IN2017
//October 20th, 2015
//Quick sort example (taken from Word document, slightly modified for my use)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_Example_10202015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 87, 45, 56, 907, 292, 2342, 2 };
            Console.WriteLine("Before the quick sort:");
            DisplayArrayValues(numbers);

            Console.WriteLine("After the quick sort:");
            QuickSortArrayValues(numbers, 0, numbers.Length - 1);
            DisplayArrayValues(numbers);

            Console.WriteLine("Hit a key to escape program.");

            Console.ReadKey();
        }

        static void DisplayArrayValues(int[] arrayValues)
        {
            for (int i = 0; i < arrayValues.Length; i++)
            {
                Console.WriteLine("{0}", arrayValues[i]);
            }
            Console.WriteLine();
        }

        static int[] QuickSortArrayValues(int[] numbers, int left, int right)
        {
            if (right > left)
            {
                int pivotIndex = left + (right - left) / 2;
 
                pivotIndex = Partition(
                    numbers, left, right, pivotIndex);
    
                QuickSortArrayValues(numbers, left, pivotIndex - 1);
   
                QuickSortArrayValues(numbers, pivotIndex + 1, right);
            }
            return numbers;
        }

        static int Partition(int[] numbers, int left, int right, int pivotIndex)
        {
            int pivotValue = numbers[pivotIndex];
     
            int temp = numbers[right];
            numbers[right] = numbers[pivotIndex];
            numbers[pivotIndex] = temp;

            int newPivot = left;
            for (int i = left; i < right; i++)
            {
                if (numbers[i] <= pivotValue)
                {
                    temp = numbers[newPivot];
                    numbers[newPivot] = numbers[i];
                    numbers[i] = temp;

                    newPivot++;
                }
            }

            temp = numbers[right];
            numbers[right] = numbers[newPivot];
            numbers[newPivot] = temp;

            return newPivot;
        }
    }
}
