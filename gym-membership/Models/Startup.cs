using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gym_membership.Models;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Add DbContext with the specified connection string
        services.AddDbContext<GymDbContext>(options =>
            options.UseSqlServer("Data Source=DESKTOP-19UR9HF\\SQLEXPRESS;Initial Catalog=GymDb;User ID=sa;Password=123;TrustServerCertificate=True")
        );

        // Other service registrations...
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configure middleware and routing
    }
}
