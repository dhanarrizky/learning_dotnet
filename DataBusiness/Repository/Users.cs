using System.Linq;
using DataAccess.Models;
using System.Collections.Generic;

namespace DataBusiness
{
     public class Users
    {
        private GoBlogContext dbContext;

        public Users()
        {
            dbContext = new GoBlogContext();
        }

        public void GetAll()
        {
            List<User> usersList = dbContext.Users.ToList(); // Use ToList() to get List<User>

            foreach (var user in usersList)
            {
                Console.WriteLine(user.UserName);
            }
        }
    }
}

