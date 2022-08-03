using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPatternProblem
{
    internal class UC_3_ValidEmail
    {
        public static void Main()
        {
            try
            {
                string email = "hello@xyzcom";
                Console.WriteLine($"The email is {email}");
                var mail = new MailAddress(email);
                bool isValidEmail = mail.Host.Contains(".");
                if (!isValidEmail)
                {
                    Console.WriteLine($"The email is invalid");
                }
                else
                {
                    Console.WriteLine($"The email is valid");
                }
                Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine($"The email is invalid");
                Console.ReadLine();
            }
        }
    }
}
