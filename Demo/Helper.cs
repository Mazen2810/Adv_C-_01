using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T>
    {
        public static int LinearSearch(T[] Arr, T Value)
        {
            if(Arr?.Length > 0 && Value is not null)
            {
                for(int i = 0; i < Arr.Length; i++)
                {
                    if (Value.Equals(Arr[i]))
                        return i;
                }
            }
            return -1;
        }

        public static void SWAP(ref T X , ref T Y)
        {
            Console.WriteLine("******* SWAP *******");
            T Temp = X;
            X = Y;
            Y=Temp;
        }

    }
}
