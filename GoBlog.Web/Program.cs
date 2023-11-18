using DataAccess;

namespace GoBlog.Web;
public class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        IServiceCollection services = builder.Services;
        Dependencies.ConfigurationDB(builder.Configuration,services);

        services.ConfigurationService();

        services.AddScoped<UsersService>();

        services.AddControllersWithViews();
        var app = builder.Build();

        app.UseStaticFiles();
        app.UseRouting();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action}");

        app.Run();
    }
}
