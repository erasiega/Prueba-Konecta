using Ejercicio5.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<ApplicationDbContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
    services.AddControllersWithViews();
}
