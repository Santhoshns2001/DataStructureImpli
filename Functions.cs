using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericAssignment0104
{
    internal class Functions
    {

        //1.
        internal static void Swap<T>(T[] v1, T[] v2)
        {

            Swap(v1);
            Console.WriteLine();
            Swap(v2);
        }

        private static void Swap<T>(T[] v1)
        {
            Console.WriteLine("After swapping");
            for (var i = v1.Length - 1; i >= 0; i--)
            {
                Console.Write(v1[i] + " ");
            }

        }


        //2.

        public static void ReverseArray<T>(T[] arr)
        {
            for(var i=arr.Length-1; i >= 0; i--)
            {
                Console.Write(arr[i]+" ");
            }

        }

        
    }
}
