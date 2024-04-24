using System.Text.RegularExpressions;

namespace Kata_1.Utils
{
    public class ValidPassword
    {
        public static string Validate(string pass)
        {
            var passwordRegex = "^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$";

            var isValid = Regex.Match(pass, passwordRegex);

            if (isValid.Success == true) return pass;
            
            throw new Exception("The Password is not valid, please verify"); 
        }
    }
}
