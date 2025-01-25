using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q3
{
    internal class Reverse
    {

        public static void reverse<T>(T [] Arr , Func<T , T , bool> comparer) where T : IComparable<T>
        {
            for (int i = 0; i < Arr.Length; i++)
            {

                for (int j = 0; j < Arr.Length - 1 - i; j++)
                {
                    if (comparer(Arr[j] , Arr[j+1]))
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
