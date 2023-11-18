using DataAccess.Models;
// using System.Collections.Generic;

namespace DataBusiness;

public interface IUsersRepository
{
    public List<User> GetAll();
    public User GetById(ulong id);
}
