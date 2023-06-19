using EFCoreBasics.Models;

namespace EFCoreBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeContext context = new EmployeeContext();
            context.Database.EnsureCreated();
            Employee employee = new Employee();
            employee.Name = "Test Employee";
            context.Employees.Add(employee);

            context.SaveChanges();

            Console.WriteLine("Hello, World!");
        }
    }
}