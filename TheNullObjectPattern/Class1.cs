using System;

namespace TheNullObjectPattern
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("IUserRepository does not implement NULL object pattern...");
            IUserRepository repository = new UserRepository();

            //Problem with code below is it gets litterred with if...else...
            //For every object we have to check for the null object, this is because if there
            //is no check, we may run into runtime exception.
            var user1 = repository.GetUserById("1");
            if (user1 != null)
            {
                Console.WriteLine("User1's name is " + user1.firstName + " " + user1.lastName);
            }
            else
            {
                Console.WriteLine("User1 not found!");
            }
            var user7 = repository.GetUserById("7");
            if (user7 != null)
            {
                Console.WriteLine("User7's name is " + user7.firstName + " " + user7.lastName);
            }
            else
            {
                Console.WriteLine("User7 not found!");
            }
            //Here is an improvised version of same code, using a NullObject of user class...
            IUserRepository repository2 = new UserRepository2();
            var user2 = repository2.GetUserById("2");
            Console.WriteLine("User 2's name is " + user2.firstName + " " + user2.lastName);
            var user9 = repository2.GetUserById("9");
            Console.WriteLine("User 9's name is " + user9.firstName + " " + user9.lastName);
            Console.ReadKey();
            //Notice the cleanliness of code. Also notice that nothing has been printed as
            //user 9's name. If there are subsequent objects building on user object's own
            //properties, forming a hierarchy of parent objects, they all should implement
            //null pattern. Eventually at a point where hierarchy ends, a simple null check
            //will ensure clean and easy to understand code.
        }
    }
}
