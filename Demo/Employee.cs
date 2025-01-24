using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class  Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public override bool Equals(object? obj) /*obj = new Employee() { Id = 10, Name = "Ahmed", Salary = 5_000 };*/
        {
            Employee? other = obj as Employee; // unsafe Casting: Compiler can't enforce type safety[May throw an Exception]
           
            if(other == null) return false;
            return (this.Id == other.Id) && (this.Name == other.Name) && (this.Salary == other.Salary);

        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id, this.Name, this.Salary);
        }
    }
}
