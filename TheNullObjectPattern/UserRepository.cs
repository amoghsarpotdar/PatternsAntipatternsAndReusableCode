using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNullObjectPattern
{
    class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>();

        public UserRepository()
        {
            users.Add(new User {firstName = "Jason", lastName="Bourne", userId = "1"});
            users.Add(new User { firstName = "James", lastName = "Bond", userId = "2" });
            users.Add(new User { firstName = "Dr", lastName = "No", userId = "3" });
            users.Add(new User { firstName = "Another", lastName = "User", userId = "4" });
        }

        public IUser GetUserById(string Id)
        {
            IUser userFound = users.SingleOrDefault(u => u.userId == Id);
            return userFound;
        }
    }
}
