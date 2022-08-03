using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPatternProblem
{
    internal class UC_9_ClearAllEmailSamples
    {
        public static void Main()
        {
            List<string> result = new List<string>();

            Console.WriteLine("LOOP");
            while (true)
            {
                int position_of_at = emails.IndexOf("@");
                if (position_of_at == -1)
                {
                    break;
                }

                int position_of_comma = emails.IndexOf(",", position_of_at);
                if (position_of_comma == -1)
                {
                    result.Add(emails);
                    break;
                }

                string email = emails.Substring(0, position_of_comma);
                result.Add(email);
                emails = emails.Substring(position_of_comma + 1);
            }
            Console.WriteLine("/LOOP");
            var i = 1;
            if (result.Count == 6)
                Console.WriteLine("SUCCESS: " + result.Count);
            else
                Console.WriteLine("FAILURE: " + result.Count);
            foreach (string emailAddress in result)
            {
                Console.WriteLine("==== " + i.ToString());
                Console.WriteLine(emailAddress);
                Console.WriteLine("/====");
                MailAddress mailAddress = new MailAddress(emailAddress);
                Console.WriteLine(mailAddress.DisplayName);
                Console.WriteLine("---- " + i.ToString());
                i++;
            }
        }
    }
}
