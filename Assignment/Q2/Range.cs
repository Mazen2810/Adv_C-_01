using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q2
{
    internal class Range<T> where T : IComparable<T>
    {

        public T Max { get; set; }
        public T Min { get; set; }
        public Range(T Value01 , T Value02)
        {
            if(Value01.CompareTo(Value02) > 0)
            {
                Max = Value01;
                Min = Value02;
            }
            else
            {
                Max = Value02;
                Min = Value01;
            }
        }

        public void IsInRange(T Value)
        {
            if(Value.CompareTo(Min)> 0 && Value.CompareTo(Max) < 0)
                Console.WriteLine("True");
            
            else
                Console.WriteLine("False");
        }

        ///public T Length()
        ///{
        ///    return 
        ///}
    }
}
