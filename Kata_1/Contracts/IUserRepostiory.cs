
using Kata_1.Entities;

namespace Kata_1.Contracts;

public interface IUserRepostiory
{
    public void CreateNewUser(User user);
    public List<User> GetUsersList();
}
