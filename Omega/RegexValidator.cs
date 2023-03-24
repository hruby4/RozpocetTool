using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Omega
{
    public static class RegexValidator
    {
        public static bool one_nonDigit_Word(string word) {
            string oneWord = @"^[a-zA-Za-zA-ZáčďéěíňóřšťůúýžÁČĎÉĚÍŇÓŘŠŤŮÚÝŽ]+$";
            Regex rg = new Regex(oneWord);
            return rg.Match(word).Success;
        }

        public static bool one_digit_Word(string word)
        {
            string oneWord = @"^[a-zA-Za-zA-ZáčďéěíňóřšťůúýžÁČĎÉĚÍŇÓŘŠŤŮÚÝŽ0-9]+$";
            Regex rg = new Regex(oneWord);
            return rg.Match(word).Success;
        }

        public static bool password(string word)
        {
            string oneWord = @"^.{3,}$";
            Regex rg = new Regex(oneWord);
            return rg.Match(word).Success;
        }
    }
}
