using System.Linq;
using DataAccess.Models;
using System.Collections.Generic;

namespace DataBusiness
{
     public class UsersRepository:IUsersRepository
    {
        private readonly GoBlogContext _dbContext;

        public UsersRepository(GoBlogContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<User> GetAll()
        {
            var query = from users in _dbContext.Users
                        select users;
            return query.ToList();
        }

        public User GetById(ulong id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id)??
                throw new NullReferenceException($"User not found in id {id}");
        }
    }
}

