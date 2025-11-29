using BlazorApp.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class EmployeeDetails
    {
        [Parameter]
        public int id { get; set; } // Route parameter to capture employee ID
        public Employee employee = new Employee();
        public EmployeeDetails()
        {
            Console.WriteLine($"Employee ID: {id}");
        }

        protected override void OnInitialized()
        {
            // Console.WriteLine($"Employee ID on initialization: {id}");
            // EmployeeService employeeService = new EmployeeService();
            employee = EmployeeService.GetEmployeeById(id);
            base.OnInitialized();
        }
    }
}
