using Kata_1.Contracts;
using Kata_1.Entities;

namespace Kata_1.Repository;

public class UserRepository : IUserRepostiory
{
    private List<User> _users = new List<User>();
    public void CreateNewUser(User user)
    {
       _users.Add(user);
    }

    public List<User> GetUsersList()
    {
        return _users;
    }
}
