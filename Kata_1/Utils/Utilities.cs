
using Kata_1.Entities;

namespace Kata_1.Utils;
public static class Utilities
{
    
    public static void CreateNewUser(User user)
    {
        var jsonUser = JsonConverter.ToJson(user);
        Console.WriteLine($"New user Created: {jsonUser}");
    }
}
