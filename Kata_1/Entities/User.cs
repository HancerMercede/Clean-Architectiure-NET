using Kata_1.Utils;
using Kata_1.ValueObjects;

namespace Kata_1.Entities;

public record User(string pName, string pEmail, string pPassword)
{
    public string Name { get; set; } = pName;
    public  Email Email { get; set; } = new Email(pEmail);
    public Password Password { get; set; } = new Password(pPassword);
}
