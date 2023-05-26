
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittTesting1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hospital hospital = new Hospital();

            // Adding Employees
            Nurse nurse1 = new Nurse() { Name = "Jane Doe", HireDate = new DateTime(2015, 3, 1), Position = "Head Nurse", Department = "Pediatric" };
            Doctor doctor1 = new Doctor() { Name = "John Smith", HireDate = new DateTime(2010, 6, 1), Position = "Senior Doctor", Department = "Orthopedic", Degrees = new System.Collections.Generic.List<string> { "MD", "PhD" }, WorksWith = new System.Collections.Generic.List<string> { "Mary Lee", "Tom Jones" } };
            StaffOfManagement management1 = new StaffOfManagement() { Name = "Alice Brown", HireDate = new DateTime(2018, 1, 1), Position = "Director", Department = "Finance" };
            hospital.AddEmployee(nurse1);
            hospital.AddEmployee(doctor1);
            hospital.AddEmployee(management1);

            // Listing All Employees
            Console.WriteLine("All Employees:");
            hospital.ListEmployees();

            // Searching Employees (By name)
            Console.WriteLine("\nSearch for employees by name:");
            var employeesByName = hospital.SearchByName("John");
            foreach (Employee employee in employeesByName)
            {
                Console.WriteLine($"{employee.Name}, {employee.GetType().Name}, {employee.ShowDetails()} years of service");
            }

            // Searching Employees (By Joining Year)
            Console.WriteLine("\nSearch for employees by joining year:");
            var employeesByJoiningYear = hospital.SearchByJoiningYear(2015);
            foreach (Employee employee in employeesByJoiningYear)
            {
                Console.WriteLine($"{employee.Name}, {employee.GetType().Name}, {employee.ShowDetails()} years of service");
            }

            // Searching Employees (By Position)
            Console.WriteLine("\nSearch for employees by position:");
            var employeesByPosition = hospital.SearchByPosition("Doctor");
            foreach (Employee employee in employeesByPosition)
            {
                Console.WriteLine($"{employee.Name}, {employee.GetType().Name}, {employee.ShowDetails()} years of service");
            }

            // Searching Employees (By dept)
            Console.WriteLine("\nSearch for employees by department:");
            var employeesByDepartment = hospital.SearchByDepartment("Pediatric");
            foreach (Employee employee in employeesByDepartment)
            {
                Console.WriteLine($"{employee.Name}, {employee.GetType().Name}, {employee.ShowDetails()} years of service");
            }

            // Removing Employee
            Console.WriteLine("\nRemoving an employee...");
            hospital.RemoveEmployee(doctor1);

            Console.ReadKey();
        }
    }
}
