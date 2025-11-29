using BlazorApp.Models;

namespace BlazorApp.Pages
{
    // This partial class can contain C# code for the PersonComponent.razor file.
    // Note: The class is declared as partial to complement the .razor file.
    public partial class PersonComponent 
    {
        // It has to be property not field to be bindable in Razor
        public Person Person { get; set; }
        public List<Person> People { get; set; } = new List<Person>();

        // Constructor to initialize the Person object
        public PersonComponent()
        {
            Person = new Person
            {
                Id = 1,
                Name = "John Doe",
                Age = 30
            };
            People.Add(Person);
            People.Add(new Person { Id = 2, Name = "Jane Smith", Age = 25 });
            People.Add(new Person { Id = 3, Name = "Bob Johnson", Age = 40 });
        }

        //public void GetDetails()
        //{
        //    Console.WriteLine($"Person Details: Id={Person.Id}, Name={Person.Name}, Age={Person.Age}");
        //}
    }
}
