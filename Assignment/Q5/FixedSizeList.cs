using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q5
{
    internal class FixedSizeList<T>
    {   public List<T> List { get; set; }
        public int LengthOfList { get; set; }

        public FixedSizeList(int LengthOfList)
        {
            this.LengthOfList = LengthOfList >= 0 ? LengthOfList : throw new Exception("The Length of List is Invalid"); ;
            List = new List<T>(LengthOfList);
        }

        public void Add(T item)
        {
            if (List.Count != List.Capacity)
            {
                List.Add(item);
            }
            else
                throw new Exception("The List is Already Full.");
        }


        public T Get(int index)
        {
            if(index > 0 &&  List.Count > index)
            {
                return List[index];
            }
            else
                throw new Exception("The Index is Exceeded the Range.");

        }


    }
}
