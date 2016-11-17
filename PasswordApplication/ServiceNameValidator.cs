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
    /// Returns true/false
    /// </summary>
    class ServiceNameValidator : IValidation
    {
        private string pattern = @"^[a-zA-Z0-9][a-zA-Z0-9\d_@.]{2,50}$";
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
