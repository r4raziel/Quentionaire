using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace questionnaire
{
    internal class CodeSignal_RightShiftArray
    {

        public static void process()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            arr= LeftRotate(arr);
            Console.WriteLine(string.Join(",", arr));

        }

        public static int[] RightRotate(int[] arr)
        {
            int[] t = new int[arr.Length];

            for (int i = 1; i < arr.Length; i++)
            {
                t[i]= arr[i-1];
            }

            t[0] = arr[arr.Length-1];
            return t;

        }
        public static int[] LeftRotate(int[] arr)
        {
            int[] t= new int[arr.Length];

            for (int i = 0; i < arr.Length-1; i++)
            {
                t[i] = arr[i + 1];
            }
            t[t.Length - 1] = arr[0];

            return t;
        }
    }
}
