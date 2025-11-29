using BlazorApp.Models;

namespace BlazorApp.Repository
{
    public class EmployeeService
    {
        List<Employee> Employees = new List<Employee>();
        public EmployeeService()
        {
            Employees.Add(new Employee { Id = 1, Name = "Mark", Salary = 5000, ImageUrl = "images/mark.png", DepartmentId = 1 });
            Employees.Add(new Employee { Id = 2, Name = "John", Salary = 6000, ImageUrl = "images/john.png", DepartmentId = 2 });
            Employees.Add(new Employee { Id = 3, Name = "Mary", Salary = 7000, ImageUrl = "images/mary.png", DepartmentId = 1 });
            Employees.Add(new Employee { Id = 4, Name = "Steve", Salary = 8000, ImageUrl = "images/steve.png", DepartmentId = 3 });
            Employees.Add(new Employee { Id = 5, Name = "Sara", Salary = 9000, ImageUrl = "images/sara.png", DepartmentId = 2 });
            Employees.Add(new Employee { Id = 6, Name = "Paul", Salary = 10000, ImageUrl = "images/paul.png", DepartmentId = 3 });
        }
        public List<Employee> GetAllEmployees()
        {
            return Employees;
        }
        public Employee? GetEmployeeById(int id)
        {
            return Employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
