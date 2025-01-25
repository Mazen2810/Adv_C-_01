
using Assignment.Q2;
using Assignment.Q3;

namespace Assignment
{
    internal class Program
    {
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

        }
    }
}
