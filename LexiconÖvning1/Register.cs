using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconÖvning1;

public class Register
{
    private static Register _instance;
    private List<Employee> _registers = new List<Employee>();
    private int Id = 1;
    private Register() { }

    public static Register Instance
    {
        get { return _instance ??= new Register(); }
    }

    public void AddEmployee(string name, double salary)
    {
        // increment Id for each new employee to make them unique
        _registers.Add(new Employee(Id++, name, salary));
        Console.WriteLine($"Employee {name} has been added.");
    }

    public List<Employee> GetAllEmployees()
    {
        return _registers;
    }
    public void Clear()
    {
        _registers.Clear();
        Id = 1;
    }
}
