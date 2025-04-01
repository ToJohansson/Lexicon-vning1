using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconÖvning1;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
    public Employee(int id, string name, double salaray)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salaray;
    }
    public Employee() { }
    public override string ToString()
    {
        return $"ID: {Id,-5} | {Name,-20} | {Salary,10:F2} SEK";
    }
}
