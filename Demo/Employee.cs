﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    internal class EmployeeEqualityComparerById : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Id == y?.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Id);
        }
    }
    internal class EmployeeEqualityComparerByName : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x?.Name == y?.Name;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.Name);
        }
    }

    internal class EmployeeComparerById : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Id.CompareTo(y?.Id ?? 0) ?? -1;
        }
    }

    internal class EmployeeComparerByName : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            return x?.Name?.CompareTo(y?.Name) ?? (y is null ? 0 : -1);
        }
    }
    internal class Employee : IEquatable<Employee> , IComparable<Employee>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return this.Salary.CompareTo(other.Salary); // Compare to will use the generic 

            //return this.Salary.CompareTo(other?.Salary); // compare to will use the object

            /// if (other == null) return 1;
            /// if (this.Salary > other.Salary) return 1;
            /// else if (this.Salary < other.Salary) return -1;
            /// return 0;
        }

        

        /// public override bool Equals(object? obj) /*obj = new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 };*/
        /// {
        ///     // Employee? other = (Employee) obj; // unsafe Casting: Compiler can't enforce type safety[May throw an Exception]
        ///     Employee? other = obj as Employee; // if failed it returns null
        ///
        ///     if (other == null) return false;
        ///     return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);
        ///
        /// }

        #region Object Methods

        public bool Equals(Employee? other)
        {
            if (other is null) return false;
            return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);

        }

        // employee01 = { Id = 10 , Name = "Ahmed", Salary = 1000}
        // employee02 = { Id = 1000 , Name = "Ahmed", Salary = 10}

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Name, this.Salary);


            /// int hashValue = 11;
            /// hashValue = (hashValue * 7) + Id.GetHashCode();
            /// hashValue = (hashValue * 7) + Name?.GetHashCode() ?? default(int);
            /// hashValue = (hashValue * 7) + Salary.GetHashCode();
            /// return hashValue;

            //return this.Id.GetHashCode() ^ this.Name?.GetHashCode() ?? default(int) ^ this.Salary.GetHashCode();

            // return this.Id.GetHashCode() + this.Name?.GetHashCode() ?? default(int) + this.Salary.GetHashCode(); 
        }


        public override string ToString()
        {
            return $"Id : {Id} , Name : {Name}, Salary: {Salary}";
        } 
        #endregion
    }
}
