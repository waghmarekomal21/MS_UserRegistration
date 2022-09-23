using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSUserRegistration
{
    public class UC7Rule3
    {

        public string password;

        public UC7Rule3(string password)
        {
            this.password = password;
        }

        public string ValidatePassword()
        {
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasNumber = new Regex(@"[0-9]+");
            var hasMiniChars = new Regex(@".{8,}");
            var pattern = new Regex("^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$");
            if (!hasMiniChars.IsMatch(password))
            {
                Console.WriteLine("Password should have minimum 8 characters");
                return null;
            }
            else if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("Password should have at least 1 lower char");
                return null;
            }
            else if (!hasUpperChar.IsMatch(password))
            {
                Console.WriteLine("Password should have at leat one upper character");
                return null;
            }
            else if (!hasNumber.IsMatch(password))
            {
                Console.WriteLine("Password should have at least one numeric number");
                return null;
            }
            else if (pattern.IsMatch(password))
            {
                return password;
            }
            else
            {
                return null;
            }
        }
    }
}