using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPatternProblem
{
    internal class UC_4_PredefindMobileFormate
    {
        public static void Main()
        {
            Stopwatch sw;
            string[] addresses = { "AAAAAAAAAAA@contoso.com",
                             "AAAAAAAAAAaaaaaaaaaa!@contoso.com" };
            string pattern = @"^[0-9A-Z]([-.\w]*[0-9A-Z])*$";
            string input;

            foreach (var address in addresses)
            {
                string mailBox = address.Substring(0, address.IndexOf("@"));
                int index = 0;
                for (int ctr = mailBox.Length - 1; ctr >= 0; ctr--)
                {
                    index++;

                    input = mailBox.Substring(ctr, index);
                    sw = Stopwatch.StartNew();
                    Match m = Regex.Match(input, pattern, RegexOptions.IgnoreCase);
                    sw.Stop();
                    if (m.Success)
                        Console.WriteLine("{0,2}. Matched '{1,25}' in {2}",
                                          index, m.Value, sw.Elapsed);
                    else
                        Console.WriteLine("{0,2}. Failed  '{1,25}' in {2}",
                                          index, input, sw.Elapsed);
                }
                Console.WriteLine();
            }
        }
    }
}
