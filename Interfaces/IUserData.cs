using System.Collections.Generic;

namespace UnitTests.Interfaces
{
    public interface IUserData
    {
        List<User> GetAllUsers();

        User GetUser(int id);

        void Create(User user);
    }
}
