using Kata_1.Contracts;
using Kata_1.Dtos;
using Kata_1.Entities;
using System.Security.Cryptography.X509Certificates;

namespace Kata_1.UseCases;

public class CreateNewUserUseCase : ICreate
{
    private readonly IUserRepostiory _repository;
    public CreateNewUserUseCase(IUserRepostiory repostiory)
    {
        _repository = repostiory;
    }
    public User Execute(UserInfoDto user)
    {
        // verify the list if the user with the email alredy exist in the list of users.
        var duplicate = _repository.GetUsersList().FirstOrDefault(x => x.pEmail == user.Email);


        // if there is a duplicate throw an error.
        if (duplicate is not null)
        {
            throw new Exception("The email already exist");
        }

        // Create a instance of User Class and pass the userInfo to check the values.
        var newUser = new User(user.Name, user.Email, user.Password);

        // Create the user.
        _repository.CreateNewUser(newUser);

        // and return the user created.
        return newUser;
    }
}
