using System.Text.RegularExpressions;

namespace Kata_1.ValueObjects;

public record Password
{
    public string PasswordProp { get; set; }
    public Password(string pass)
    {
        PasswordProp = pass;
        ValidatePassword(pass);
    }
    public string ValidatePassword(string pass)
    {
        if (string.IsNullOrEmpty(pass)) throw new Exception("The password is Required.");

        var passwordRegex = @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$";

        var isValid = Regex.Match(pass, passwordRegex);

        if (!isValid.Success) throw new Exception("The Password is not valid, please verify");

        return pass;
    }
}
