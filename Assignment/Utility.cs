using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal static class  Utility
    {
        public static void BubbleSort<T>(T[] Arr) where T : IComparable<T>
        {
            for(int i = 0; i< Arr.Length; i++)
            {

                for(int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (Arr[j].CompareTo(Arr[j + 1]) == 1)
                    {
                        T Temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = Temp;
                    }
                }
            }
        }
    }
}
