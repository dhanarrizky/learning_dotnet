using DataBusiness.Repository;
using DataBusiness.InterfaceRepository;


namespace GoBlog.Web;

public class ConfigurationBusinessService
{
    public static IServiceCollection ConfigurationService(this IServiceCollection service)
    {
        service.AddScoped<IUsersRepository,UsersRepository>();
    }
}
