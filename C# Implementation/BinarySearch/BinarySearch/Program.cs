using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the number list: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter value for the array index " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the value you want to find: ");
            int key = int.Parse(Console.ReadLine());

            int value = binarySearch(arr, key);

            if (value == -1)
            {
                Console.WriteLine("Value not found");
            }
            else
            {
                Console.WriteLine("Value found at position " + value);
            }

            Console.ReadLine();
        }

        public static int binarySearch(int[] arr, int key)
        {
            int starting = 0;
            int ending = arr.Length;

            while (starting < ending)
            {
                int mid = (starting + ending) / 2;
                if (key < arr[mid])
                {
                    ending = mid - 1;
                }
                else if (key > arr[mid])
                {
                    starting = mid + 1;
                }
                else
                {
                    return (mid+1);
                }
            }
            return -1;
        }

    }
}
