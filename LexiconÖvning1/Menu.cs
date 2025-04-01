using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LexiconÖvning1;

internal class Menu
{
    string name = "";
    double salary = 0;
    string choice = "";
    public Menu()
    {
    }
    private void CreateEmployee()
    {
        Console.WriteLine("Enter employee's fullname: ");
        name = Console.ReadLine();
        while (string.IsNullOrEmpty(name))
        {
            Console.WriteLine("Name cannot be empty. Enter employee's fullname: ");
            name = Console.ReadLine();
        }
        Console.WriteLine("Enter employee's monthly salary in SEK: ");
        while (!double.TryParse(Console.ReadLine(), out salary))
        {
            Console.WriteLine("Invalid input. Please enter a number: ");
        }
        Register.Instance.AddEmployee(name, salary);
    }
    private void ShowEmployees()
    {
        var employees = Register.Instance.GetAllEmployees();
        foreach (var employee in employees)
        {
            Console.WriteLine(employee.ToString());
        }
    }
    public void Run()
    {

        do
        {
            Console.WriteLine("Welcome to the employee register page!");
            Console.WriteLine("1. Add employee");
            Console.WriteLine("2. Show all employees");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Please enter your choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    CreateEmployee();
                    break;
                case "2":
                    ShowEmployees();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
            Console.Clear();

        } while (true);
    }
}
