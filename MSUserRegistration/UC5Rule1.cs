using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MSUserRegistration
{
    public class UC5Rule1
    {
        public string password;

        public UC5Rule1(string password)
        {
            this.password = password;
        }

        public string ValidatePassword()
        {
            var hasLowerChar = new Regex("^(?=.*[a-z]).{8,}$");
            if (!hasLowerChar.IsMatch(password))
            {
                Console.WriteLine("password should have minimum 8 characters");
                return null;
            }
            else
            {
                //Console.WriteLine("Password is valid");
                return password;
            }
        }
    }
}