using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kata_1.ValueObjects
{
    public class Email
    {
        public string EmailProp { get; set; }

        public Email(string emailparam)
        {
            this.EmailProp = emailparam;
            IsValid(emailparam);
        }

       public void IsValid(string emailparam)
        {
            var emailRegex = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            var isValid = Regex.Match(emailparam, emailRegex);

            if (isValid.Success ==false) throw new Exception("The email is invalid");

            EmailProp = emailparam;
        }

    }
 
}
