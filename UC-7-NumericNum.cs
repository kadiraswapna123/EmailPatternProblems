using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPatternProblem
{
    internal class UC_7_SpecialChar
    {
        String[] passwords = { "foobar", "Foobar", "Foobar1", "Fooobar12" };
        foreach (String s in passwords) {

        Match password = Regex.Match(s, @"
                                      ^              # Match the start of the string
                                       (?=.*\p{Lu})  # Positive lookahead assertion, is true when there is an uppercase letter
                                       (?=.*\P{L})   # Positive lookahead assertion, is true when there is a non-letter
                                       \S{8,}        # At least 8 non whitespace characters
                                      $              # Match the end of the string
                                     ", RegexOptions.IgnorePatternWhitespace);

        if (password.Success) {
        Console.WriteLine(s + ": valid");
       else
       {
           Console.WriteLine(s + ": invalid");
       }
    }
}



Console.ReadLine();
    }
}

   

