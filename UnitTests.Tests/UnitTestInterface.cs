using System.Collections.Generic;
using Xunit;
using Moq;
using UnitTests.Interfaces;
using UnitTests.Controllers;

namespace UnitTests.Tests
{
    public class UnitTestInterface
    {
        //[Fact]
        //public void TestWithoutInterface()
        //{
        //    //Arrange
        //    var mock = new Mock<IUserData>();
        //    mock.Setup(inter => inter.GetAllUsers()).Returns(GetTestAllUsers());
        //    var controller = new PseudoController(mock.Object);

        //    //Act
        //    var result = controller.ReturnUsers();

        //    //Assert
        //    Assert.IsType<List<User>>(result);
        //}

        //private List<User> GetTestAllUsers() => new List<User>
        //    {
        //        new User { Id = 1, Name = "A", Age = 18},
        //        new User { Id = 2, Name = "B", Age = 19},
        //        new User { Id = 3, Name = "C", Age = 20},
        //        new User { Id = 4, Name = "D", Age = 21},
        //        new User { Id = 5, Name = "E", Age = 22}
        //    };
    }
}
