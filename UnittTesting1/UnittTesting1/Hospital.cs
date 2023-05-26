using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnittTesting1
{
    public class Hospital
    {
        public List<Employee> employees;

        public Hospital()
        {
            employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            employees.Remove(employee);
        }

        public void ListEmployees()
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine($"{employee.Name}, {employee.GetType().Name}, {employee.ShowDetails()} years of service");
            }
        }

        public List<Employee> SearchByName(string name)
        {
            return employees.FindAll(employee => employee.Name.Contains(name));
        }

        public List<Employee> SearchByJoiningYear(int year)
        {
            return employees.FindAll(employee => employee.HireDate.Year == year);
        }

        public List<Employee> SearchByPosition(string position)
        {
            return employees.FindAll(employee => employee.GetType().GetProperty("Position")?.GetValue(employee, null)?.ToString().Contains(position) ?? false);
        }

        public List<Employee> SearchByDepartment(string department)
        {
            return employees.FindAll(employee => employee.GetType().GetProperty("Department")?.GetValue(employee, null)?.ToString().Contains(department) ?? false);
        }
    }
}
