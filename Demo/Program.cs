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


            #region Generics - LinearSearch Example 02
            /// int[] Numbers = [10, 2, 32, 3, 12, 34, 11, 33];
            ///
            /// int result = Helper.LinearSearch(Numbers, 11);
            /// Console.WriteLine($"index = {result}");

            /// Employee[] employees =
            /// {
            ///     new Employee(){Id = 10 , Name = "Ahmed",   Salary = 8_000},
            ///     new Employee(){Id = 20 , Name = "Mohamed", Salary = 3_000},
            ///     new Employee(){Id = 30 , Name = "Omnia",   Salary = 2_000},
            ///     new Employee(){Id = 40 , Name = "Mazen",   Salary = 7_000},
            /// };
            ///
            /// int index = Helper<Employee>.LinearSearch(employees, new Employee() { Id = 40, Name = "Mazen", Salary = 7_000 });
            /// Console.WriteLine($"Index: {index}");

            ///  Employee E01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 };
            ///  Employee E02 = new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 };
            ///
            ///  if (E01.Equals(E02))
            ///  //if(E01 == E02)
            ///      Console.WriteLine("Equals");
            ///  else
            ///      Console.WriteLine("!Equals"); 
            #endregion


            #region Equality (== & Equals) & GetHashCode
            // Employee E01 = new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 };
            // Employee E02 = new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 };

            //// Console.WriteLine($"E01.GetHashCode() : {E01.GetHashCode()}");
            //// Console.WriteLine($"E02.GetHashCode() : {E02.GetHashCode()}");

            // ///if (E01.Equals(E02))
            // ///    //if(E01 == E02)
            // ///    Console.WriteLine("Equals");
            // ///else
            // ///    Console.WriteLine("!Equals");

            // HashSet<Employee> employees = new HashSet<Employee>();
            // employees.Add(E01);
            // employees.Add(E02);

            // foreach (Employee emp in employees)
            //     Console.WriteLine(emp); 
            #endregion
        }
    }
}
