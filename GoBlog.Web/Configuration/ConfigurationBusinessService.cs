using DataBusiness;
// using Microsoft.Extensions.DependencyInjection;

namespace GoBlog.Web;

public static class ConfigurationBusinessService
{
    public static IServiceCollection ConfigurationService(this IServiceCollection service)
    {
        service.AddScoped<IUsersRepository,UsersRepository>();
        return service;
    }
}
