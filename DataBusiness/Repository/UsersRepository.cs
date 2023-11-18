using System.Linq;
using DataAccess.Models;
// using System.Collections.Generic;

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

        public User Create(User user)
        {
            _dbContext.Users.Add(user);
            var affectedRows = _dbContext.SaveChanges();
            if(affectedRows > 0){
                return user;
            } else {
                return null;
            }
        }

        public int Update(User user)
        {
            _dbContext.Users.Update(user);
            return _dbContext.SaveChanges();
        }

        public int Delete(ulong id)
        {
            var user = GetById(id);
            if (user != null) {
                _dbContext.Users.Remove(user);
                return _dbContext.SaveChanges();
            } else {
                return -1;
            }
        }
    }
}

// public string UpdateUserById(User user)
// {
//     _dbContext.Users.Update(user);
    
//     // Attempt to save changes
//     int affectedRows = _dbContext.SaveChanges();

//     if (affectedRows > 0)
//     {
//         return "Updated user has been successfully";
//     }
//     else
//     {
//         return "No changes were made or an error occurred during the update.";
//     }
// }