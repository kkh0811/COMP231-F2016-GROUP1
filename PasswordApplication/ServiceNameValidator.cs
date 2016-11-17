using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.Interfaces;
using System.Text.RegularExpressions;
using PasswordApplication.Model;

namespace PasswordApplication
{
    /// <summary>
    /// ServiceNameValidator validates that user inputs the appropriate string.
    /// [a-zA-Z0-9] = can repeat alphabet or letter
    /// [a-zA-Z0-9\d_@.\s*] allow all alphabets and numbers and _ @ . whitespace
    /// {1,50}$ = minimum 2 characters to 50 max
    /// Returns true/false
    /// </summary>
    class ServiceNameValidator : IValidation
    {
        private string pattern = @"^[a-zA-Z0-9][a-zA-Z0-9\d_@.\s*]{1,50}$";
        Regex regex;
        bool result;
        public bool Validate(string UserInput)
        {
            regex = new Regex(pattern);
            try
            {
                if (regex.Match(UserInput).Success)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch (Exception e)
            {
                //output the exception error
                Console.WriteLine(e);
            }
            return result;
        }
    }
}
