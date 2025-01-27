
using Assignment.Q2;
using Assignment.Q3;
using Assignment.Q5;

namespace Assignment
{

    internal class Program
    {
        static int FirstNonRepeatedCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (charCount.ContainsKey(c))
                    charCount[c]++;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (charCount[input[i]] == 1)
                    return i;
            }

            return -1;
        }
        static void Main(string[] args)
        {
            #region Q1: Bubble Sort algorithm
            //string[] Names = ["Mazen", "Ahmed", "Ziad", "Hassan"];
            //Utility.BubbleSort(Names);

            //foreach (string Name in Names)
            //    Console.WriteLine(Name); 
            #endregion


            #region Q2: create a generic Range<T> class
            // Assignment.Q2.Range<int> NumRange = new Assignment.Q2.Range<int>(20, 10);
            //
            // NumRange.IsInRange(15);  // True
            // NumRange.IsInRange(25);  // False


            // Assignment.Q2.Range<string> StringRange = new Assignment.Q2.Range<string>("Ahmed", "Yasser");
            //
            // StringRange.IsInRange("Mazen");  // True
            // StringRange.IsInRange("Ziad");   // False 
            #endregion

            #region Q3: try to reverse the order of elements in the ArrayList in-place
            /// int[] Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            /// 
            /// Reverse.reverse(Numbers, delegate (int X, int Y)
            /// {
            ///     return X.CompareTo(Y) == -1;   // it will reverse accodring to the delegate
            /// });
            /// 
            /// foreach (int number in Numbers)
            ///     Console.WriteLine(number);


            ///  string[] Names = ["Ahmed", "Bassem", "Menna", "Yasser", "Ziad"];
            /// 
            ///  Reverse.reverse(Names, delegate (string X, string Y)
            ///  {
            ///      return X.CompareTo(Y) == -1;  // it will reverse accodring to the delegate
            ///  });
            /// 
            ///  foreach (string name in Names)
            ///     Console.WriteLine(name); 
            #endregion

            #region Q4: You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            // List<int> Numbers = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            // List<int> EvenNumbers = new List<int>();
            //
            // for(int i = 0; i < Numbers.Count; i++)
            // {
            //     if (Numbers[i] % 2 == 0)
            //         EvenNumbers.Add(Numbers[i]);
            // }
            //
            // foreach(int even in EvenNumbers)
            //     Console.WriteLine(even);
            #endregion


            #region Q5: implement a custom list called FixedSizeList<T> 

            //FixedSizeList<int> fixedList = new FixedSizeList<int>(4);
            //fixedList.Add(1);
            //fixedList.Add(2);
            //fixedList.Add(3);
            //fixedList.Add(4);
            // Console.WriteLine("**************** Before the Exceeded Exception ****************");
            //
            // foreach (int i in fixedList.List)
            //     Console.WriteLine(i);
            //
            // Console.WriteLine("**************** After the Exceeded Exception ****************");
            //
            // fixedList.Add(5);


            // Console.WriteLine("**************** Before the OutofRange Exception ****************");
            // 
            // int item = fixedList.Get(3);
            // Console.WriteLine(item);
            // 
            // 
            // Console.WriteLine("**************** After the OutofRange Exception ****************");
            // 
            // fixedList.Get(13); 
            #endregion


            #region Q6:Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. Hint you can use dictionary


            int Result = FirstNonRepeatedCharacter("MazenMohmaed");
            if (Result != -1)
                Console.WriteLine($"The first non-repeated character is at index: {Result}");
            else
                Console.WriteLine("No non-repeated character found.");
            #endregion  
        }
    }
}
