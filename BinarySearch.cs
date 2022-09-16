using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class BinarySearch
    {

        public int BinarySearchMethod(int[] arr, int key)
        {
            int left = 0;
            int right = arr.Length;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (key == arr[mid])
                {
                    return ++mid;
                }
                else if (arr[mid] > key)
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;

        }

        public void process()
        {
            Console.WriteLine("processing bianry search...");
            int[] A = { 0, 4, 7, 10, 14, 23, 25, 47, 53,87,92};
            int Key = 47;

            Console.WriteLine("Result:" + string.Join(",", BinarySearchMethod(A, Key)));

        }
    }
}
