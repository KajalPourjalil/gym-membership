using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
// Other namespaces as needed...

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Configure services, including DbContext registration
        services.AddDbContext<GymDbContext>(options =>
            options.UseSqlServer("Data Source=DESKTOP-19UR9HF\\SQLEXPRESS;Initial Catalog=GymDb;User ID=sa;Password=123;TrustServerCertificate=True")
        );
        
        // Add other services as needed...
        services.AddControllersWithViews();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        // Configure middleware and request pipeline
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            // Configure error handling, etc.
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            // Configure additional endpoints as needed...
        });
    }
}
