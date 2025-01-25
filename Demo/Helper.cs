using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper<T> where T : IComparable<T>
    {

        public static void BubbleSort(T[] Arr)
        {
            if (Arr is null || Arr.Length == 0)  return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0;j < Arr.Length -1 -i ;j++)
                {
                    if (Arr[j].CompareTo(Arr[j+1]) == 1)
                        SWAP(ref Arr[j] , ref Arr[j+1]);
                            

                }
            }

        }

        public static void BubbleSort(T[] Arr , IComparer<T> comparer)
        {
            if (Arr is null || Arr.Length == 0) return;

            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (comparer.Compare(Arr[j] , Arr[j+1]) == 1)
                        SWAP(ref Arr[j], ref Arr[j+1]);



                }
            }

        }

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


        public static int LinearSearch(T[] Arr, T Value , IEqualityComparer<T> equalityComparer)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    // if (Value.Equals(Arr[i]))
                    if(equalityComparer.Equals(Value,Arr[i]))
                        return i;
                }
            }
            return -1;
        }
       
        public static int LinearSearch(T[] Arr, T Value , Func<T , T , bool> equals)
        {
            if (Arr?.Length > 0 && Value is not null)
            {
                for (int i = 0; i < Arr.Length; i++)
                {
                    // if (Value.Equals(Arr[i]))
                    // if(equalityComparer.Equals(Value,Arr[i]))
                     if(equals(Value,Arr[i]))

                    return i;
                }
            }
            return -1;
        }

        public static void SWAP(ref T X , ref T Y)
        {
            //Console.WriteLine("******* SWAP *******");
            T Temp = X;
            X = Y;
            Y=Temp;
        }

    }
}
