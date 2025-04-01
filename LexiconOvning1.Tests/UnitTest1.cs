using LexiconÖvning1;
using System;
using System.Collections.Generic;
using Xunit;

namespace LexiconOvn1.Tests
{
    public class RegisterTests
    {
        public RegisterTests()
        {
            // Se till att varje test börjar med en ren lista
            Register.Instance.Clear();
        }

        [Fact]
        public void AddEmployee_ShouldIncreaseCount()
        {
            // Arrange
            var register = Register.Instance;

            // Act
            register.AddEmployee("Test Employee", 50000);

            // Assert
            Assert.Single(register.GetAllEmployees());
        }

        [Fact]
        public void GetAllEmployees_ShouldReturnCorrectEmployees()
        {
            // Arrange
            var register = Register.Instance;
            register.AddEmployee("Tobbe", 45000);
            register.AddEmployee("Lobbe", 55000);

            // Act
            var employees = register.GetAllEmployees();

            // Assert
            Assert.Equal(2, employees.Count);
            Assert.Contains(employees, e => e.Name == "Tobbe" && e.Salary == 45000);
            Assert.Contains(employees, e => e.Name == "Lobbe" && e.Salary == 55000);
        }

        [Fact]
        public void Clear_ShouldRemoveAllEmployees()
        {
            // Arrange
            var register = Register.Instance;
            register.AddEmployee("Tobbe", 45000);
            register.AddEmployee("Lobbe", 55000);

            // Act
            register.Clear();

            // Assert
            Assert.Empty(register.GetAllEmployees());
        }
    }

    public class EmployeeTests
    {
        [Fact]
        public void Employee_Constructor_ShouldInitializeProperties()
        {
            // Arrange & Act
            var employee = new Employee(1, "Tobias Johansson", 60000);

            // Assert
            Assert.Equal(1, employee.Id);
            Assert.Equal("Tobias Johansson", employee.Name);
            Assert.Equal(60000, employee.Salary);
        }

        [Fact]
        public void Employee_ToString_ShouldReturnFormattedString()
        {
            // Arrange
            var employee = new Employee(2, "Tobias Johansson", 70000);

            // Act
            var result = employee.ToString();
            Console.WriteLine(result);
            // Assert
            Assert.Contains("ID: 2", result);
            Assert.Contains("Tobias Johansson", result);
            Assert.Contains("70000,00 SEK".Replace(",", "."), result.Replace(",", "."));
        }
    }
}
