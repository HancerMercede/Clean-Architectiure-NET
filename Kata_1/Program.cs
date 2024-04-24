using Kata_1.Dtos;

using Kata_1.Repository;
using Kata_1.UseCases;
using System.Text.Json;

var repo = new UserRepository();
var createNewUser = new CreateNewUserUseCase(repo);

var user = new UserInfoDto { Name = "Juan", Email = "juan@hotmail.com", Password = "" };

var newUser = createNewUser.Execute(user);
//var jsonUser = JsonSerializer.Serialize(newUser);
Console.Write(newUser);