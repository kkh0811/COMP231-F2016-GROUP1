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
    class CategoryValidator : IValidation
    {
        private string pattern = "--Select One--";
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
                    result = false;
                }
                else
                {
                    result = true;
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
