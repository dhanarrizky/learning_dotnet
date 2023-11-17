using DataAccess.Models;

namespace DataBusiness;

public interface IUsersRepository
{
    public List<User> GetAll();
    public User GetById(ulong id);
}
