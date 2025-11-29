namespace BlazorApp.Models
{
    public class SeedData
    {
        // Seed data for Departments and Students
        private static List<Department> Departments = new List<Department>
        {
            new Department { Id = 1, Name = "Computer Science" },
            new Department { Id = 2, Name = "Mathematics" },
            new Department { Id = 3, Name = "Physics" }
        };

        private static List<Student> Students = new List<Student>
        {
            new Student { Id = 1, Name = "Alice", Address = "123 Main St", DepartmentId = 1 },
            new Student { Id = 2, Name = "Bob", Address = "456 Oak Ave", DepartmentId = 2 },
            new Student { Id = 3, Name = "Charlie", Address = "789 Pine Rd", DepartmentId = 3 },
            new Student { Id = 4, Name = "Diana", Address = "321 Maple St", DepartmentId = 1 },
            new Student { Id = 5, Name = "Ethan", Address = "654 Cedar Ave", DepartmentId = 2 },
            new Student { Id = 6, Name = "Fiona", Address = "987 Birch Rd", DepartmentId = 3 },
            new Student { Id = 7, Name = "George", Address = "147 Spruce St", DepartmentId = 1 },
            new Student { Id = 8, Name = "Hannah", Address = "258 Elm Ave", DepartmentId = 2 },
        };

        public static List<Department> GetDepartments() => Departments;
        public static List<Student> GetStudents() => Students;
    }
}
