using Kata_1.Dtos;
using Kata_1.Repository;
using Kata_1.UseCases;
using Moq;

namespace TestProject1
{
    public class UserTest
    {
        [Fact]
        public void ShouldCreateANewUserTest()
        {
            // Arrange
            var MockRep = new Mock<UserRepository>();
            var createUser = new CreateNewUserUseCase(MockRep.Object);
            var user = new UserInfoDto { Name = "Joe", Email = "joe@hotmail.com", Password = "Hola123dsfs" };

            // Act
            var newUserCreated = createUser.Execute(user);

            //Assert
            Assert.NotNull(newUserCreated); // Ensure a user object is returned
            Assert.Equal(user.Name, newUserCreated.Name); // Check if the name is set correctly
            Assert.Equal(user.Email, newUserCreated.pEmail);
            Assert.Equal(user.Password, newUserCreated.pPassword);
        }

        [Fact]
        public void ShouldThrowAnErrorIfEmailIsWrongTest()
        {
            // Arrange
            var MockRep = new Mock<UserRepository>();
            var createUser = new CreateNewUserUseCase(MockRep.Object);
            var user = new UserInfoDto { Name = "Joe", Email = "joe.com", Password = "Hola123dsfs" };

            // Act
            var exception = Record.Exception(() => createUser.Execute(user));

            //Assert
            Assert.NotNull(exception); // There is an exception
            Assert.Equal("The email is invalid", exception.Message); // The message has to be equal to the expet
            Assert.False(user.Email.Contains('@')); // The email must not contain @ character
        }

        [Fact]
        public void ShouldThrowAnErrorIfPasswordIsEmptyTest()
        {
            // Arrange
            var MockRep = new Mock<UserRepository>();
            var createUser = new CreateNewUserUseCase(MockRep.Object);
            var user = new UserInfoDto { Name = "Joe", Email = "joe@test.com", Password = "" };

            // Act
            var exception = Record.Exception(() => createUser.Execute(user));

            //Assert
            Assert.NotNull(exception); // There is an exception
            Assert.Equal("The password is Required.", exception.Message); // The message has to be equal to the expet
            Assert.Empty(user.Password); // The password is empty
        }
        [Fact]
        public void ShouldThrowAnErrorIfPasswordIsMinusThan8Test()
        {
            // Arrange
            var MockRep = new Mock<UserRepository>();
            var createUser = new CreateNewUserUseCase(MockRep.Object);
            var user = new UserInfoDto { Name = "Joe", Email = "joe@test.com", Password = "fgertdf" };

            // Act
            var exception = Record.Exception(() => createUser.Execute(user));

            //Assert
            Assert.NotNull(exception); // There is an exception
            Assert.Equal("The Password is not valid, please verify", exception.Message); // The message has to be equal to the expet
            Assert.True(user.Password.Length < 8); // The password length is minus than 8
        }
     
    }


}
