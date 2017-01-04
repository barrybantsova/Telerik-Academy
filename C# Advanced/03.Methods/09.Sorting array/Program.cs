using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SortingArray
{
    class Program
    {
        static void Main(string[] args)
        { 
            int size = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Sorting(size, arr);
            Console.WriteLine(string.Join(" ", arr));
        }

        static void Sorting(int size, int[] arr)
        {
            int tempMaxValueIndex = 0;
            int tempMaxValue = 0; 

            for (int element = 0; element < size; element++)
            {
                for (int currentElement = 0; currentElement < size - element; currentElement++)
                {
                    CatchMaxVlue(arr, ref tempMaxValueIndex, ref tempMaxValue, currentElement);
                }
                ParseMaxAtLastButOnePosition(arr, size, element, ref tempMaxValueIndex, ref tempMaxValue);
            }
        }

        static void CatchMaxVlue(int[] arr, ref int tempMaxValueIndex, ref int tempMaxValue, int currentElement)
        {
            if (arr[currentElement] > tempMaxValue)
            {
                tempMaxValue = arr[currentElement];
                tempMaxValueIndex = currentElement;
            }
        }

        static void ParseMaxAtLastButOnePosition(int[] arr, int size, int element, ref int tempMaxValueIndex, ref int tempMaxValue)
        {
            int temp = 0;
            
            temp = arr[size - element - 1];
            
            arr[size - element - 1] = tempMaxValue;
            
            arr[tempMaxValueIndex] = temp;

            
            tempMaxValueIndex = 0;
            tempMaxValue = 0;
        }
    }
}

