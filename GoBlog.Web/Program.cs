using System;
using System.Collections.Generic;

using DataAccess;

namespace GoBlog.Web;
public class Program
{
    public void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        IServiceCollection services = builder.Services;
        Dependencies.CinfigurationDB(builder.Configuration,services);

        services.ConfigurationService();

        services.AddScoped<UsersService>();

        Services.AddControllersWithViews();
        var app = builder.Build();

        app.UseStaticFiles();
        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}");

        app.Run();
    }
}
