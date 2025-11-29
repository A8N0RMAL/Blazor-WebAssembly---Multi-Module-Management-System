using BlazorApp.Repository;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            // Root component registration -> <div id="app"></div> in index.html
            builder.RootComponents.Add<App>("#app"); 
            builder.RootComponents.Add<HeadOutlet>("head::after");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<EmployeeService>();
            builder.Services.AddScoped<DepartmentService>();
            builder.Services.AddScoped<ProductService>();
            builder.Services.AddScoped<CategoryService>();
            await builder.Build().RunAsync();
        }
    }
}
