using System.Text.RegularExpressions;

namespace Kata_1.Utils;

public class ValidEmail
{
  public static string ValidEmailMethod(string mail)
    {
        
            if (mail is null || mail == "") return "The Email is Required";

            var regexEmail = @"^[\w-_]+(\.[\w!#$%'*+\/=?\^`{|}]+)*@((([\-\w]+\.)+[a-zA-Z]{2,20})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$";

            var isValid = Regex.Match(mail, regexEmail)!;

            if (isValid.Success == true) return mail;

           throw new Exception("The Email is invalid, verify please.");

    }
}
