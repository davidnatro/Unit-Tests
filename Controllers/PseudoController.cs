using System.Collections.Generic;
using UnitTests.Interfaces;

namespace UnitTests.Controllers
{
    public class PseudoController
    {
        private IUserData userData;

        public PseudoController(IUserData userData)
        {
            this.userData = userData;
        }

        public List<User> ReturnUsers() => userData.GetAllUsers();
    }
}
