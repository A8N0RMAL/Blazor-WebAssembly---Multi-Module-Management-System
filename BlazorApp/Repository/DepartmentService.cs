using BlazorApp.Models;

namespace BlazorApp.Repository
{
    public class DepartmentService
    {
        List<Department> Departments = new List<Department>();
        public DepartmentService()
        {
            Departments.Add(new Department { Id = 1, Name = "IT" });
            Departments.Add(new Department { Id = 2, Name = "HR" });
            Departments.Add(new Department { Id = 3, Name = "Payroll" });
            Departments.Add(new Department { Id = 4, Name = "Admin" });
        }

        public List<Department> GetAllDepartments()
        {
            return Departments;
        }

        public Department? GetDepartmentById(int id)
        {
            return Departments.FirstOrDefault(d => d.Id == id);
        }
    }
}
