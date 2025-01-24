namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics - SWAP Example 01
            /// int A = 3, B = 5;
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");
            /// Helper.SWAP/*<int>*/(ref A, ref B);
            /// Console.WriteLine($"A = {A}");
            /// Console.WriteLine($"B = {B}");

            /// double K = 3.3, L = 4.4;
            /// Console.WriteLine($"k = {K}");
            /// Console.WriteLine($"L = {L}");
            /// Helper.SWAP/*<double>*/(ref K, ref L);
            /// Console.WriteLine($"k = {K}");
            /// Console.WriteLine($"L = {L}");


            /// Point P01 = new Point(10, 20);
            /// Point P02 = new Point(50, 60);
            /// Console.WriteLine($"P01 = {P01}");
            /// Console.WriteLine($"P02 = {P02}");
            /// Helper.SWAP/*<Point>*/(ref P01, ref P02);
            /// Console.WriteLine($"P01 = {P01}");
            /// Console.WriteLine($"P02 = {P02}"); 
            #endregion

        }
    }
}
