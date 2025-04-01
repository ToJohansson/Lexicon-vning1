using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconÖvning1
{
    internal class Menu
    {

        public Menu()
        {
        }
        public void Run()
        {
            string name = "";
            double salary = 0;
            string choice = "";
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
                        Console.WriteLine("Enter employee's fullname: ");
                        name = Console.ReadLine();
                        Console.WriteLine("Enter employee's monthly salary in SEK: ");
                        salary = Convert.ToDouble(Console.ReadLine());
                        Register.Instance.AddEmployee(name, salary);
                        break;
                    case "2":
                        Register.Instance.GetAllEmployees();
                        break;
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.ReadLine();
                Console.Clear();

            } while (true);
        }
    }
}
