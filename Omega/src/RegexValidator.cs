
using System.Text.RegularExpressions;


namespace Omega
{
    public static class RegexValidator
    {
        /// <summary>
        /// Method <c>one_nonDigit_Word</c> checks if given string is one non digit word
        /// </summary>
        /// <returns>
        /// true if word is one non digit word then false
        /// </returns>
        public static bool one_nonDigit_Word(string word) {
            string oneWord = @"^[a-zA-Za-zA-ZáčďéěíňóřšťůúýžÁČĎÉĚÍŇÓŘŠŤŮÚÝŽ]+$";
            Regex rg = new Regex(oneWord);
            return rg.Match(word).Success;
        }

        /// <summary>
        /// Method <c>one_digit_Word</c> checks if given string is a word made of digits or letters
        /// </summary>
        /// <returns>
        /// true if word is made of digits or letters then false
        /// </returns>
        public static bool one_digit_Word(string word)
        {
            string oneWord = @"^[a-zA-Za-zA-ZáčďéěíňóřšťůúýžÁČĎÉĚÍŇÓŘŠŤŮÚÝŽ0-9]+$";
            Regex rg = new Regex(oneWord);
            return rg.Match(word).Success;
        }
        /// <summary>
        /// Method <c>password</c> checks if given has 3 or more characters
        /// </summary>
        /// <returns>
        /// true if word has 3 or more characters then false
        /// </returns>
        public static bool password(string word)
        {
            string oneWord = @"^.{3,}$";
            Regex rg = new Regex(oneWord);
            return rg.Match(word).Success;
        }
    }
}
