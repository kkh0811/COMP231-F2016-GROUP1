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
    /// Validate userName input.
    /// Pattern is ?????
    /// </summary>
    class UserNameValidator : IValidation
    {
        // create pattern to match username
        //regular expression only allows user to input alphabets or numbers only. Special characters allowed are only _ @ .
        private string pattern = @"^[a-zA-Z0-9][a-zA-Z0-9\d_@.]{2,29}$";
        //instantiate Regular Expression
        Regex regex;

        public bool Validate(string UserInput)
        {
            //initialize bool variable to false when returning method
            bool result = false;
            //create obj regex and pattern is the string pattern
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
