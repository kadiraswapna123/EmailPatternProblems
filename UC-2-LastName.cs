using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPatternProblem
{
    internal class UC_2_LastName
    {
         public static string RegexRules = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        //public static string Regex_Pincode = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        //public static string regex = "^[A-Za-z0-9]+([.#_+][A-Za-z0-9]+)*[@][A-Za-z0-9]+[.][a-z]{2,3}([.][a-z]{2})?$";
        //public static string regex = "^[A-Za-z0-9]+([._#%+][A-Za-z0-9]+)?[@][A-Za-z]+[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        public bool validateString(string sample)
        {
            return Regex.IsMatch(sample, RegexRules);
        }
    }
}
