using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNullObjectPattern
{
    class UserRepository2:IUserRepository
    {
        private List<User> users = new List<User>();

        public UserRepository2()
        {
            users.Add(new User { firstName = "Jason", lastName = "Bourne", userId = "1" });
            users.Add(new User { firstName = "James", lastName = "Bond", userId = "2" });
            users.Add(new User { firstName = "Dr", lastName = "No", userId = "3" });
            users.Add(new User { firstName = "Another", lastName = "User", userId = "4" });
        }

        public IUser GetUserById(string Id)
        {
            IUser userFound = users.SingleOrDefault(u => u.userId == Id);
            //Notice that when user is not found, an instance of NullUser class is created.
            //This is our 'Null object' which ensures null values are handled correctly
            //without requiring a check on object every time it is passed from layer to layer.
            if (userFound == null)
            {
                userFound = new NullUser();
            }
            return userFound;
        }
    }
}
