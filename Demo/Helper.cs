using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class Helper
    {
        public static void SWAP<T>(ref T X , ref T Y)
        {
            Console.WriteLine("******* SWAP *******");
            T Temp = X;
            X = Y;
            Y=Temp;
        }

    }
}
