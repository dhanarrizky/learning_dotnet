using DataAccess.Models;
// using System.Collections.Generic;

namespace DataBusiness;

public interface IUsersRepository
{
    public List<User> GetAll();
    public User GetById(ulong id);
    public User Create(User user);
    public int Update(User user);
    public int Delete(ulong id);
}
