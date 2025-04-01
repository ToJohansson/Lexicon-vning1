using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconÖvning1
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee(int id)
        {
            this.Id = id;
        }
        public Employee() { }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Salary: {Salary}";
        }
    }
}
