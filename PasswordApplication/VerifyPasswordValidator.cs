using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.Model;
using PasswordApplication.Interfaces;
using System.Text.RegularExpressions;

namespace PasswordApplication
{
    /// <summary>
    /// This class interface from IValidation. 
    /// Class will validate that the verify password text box is identical to the password text box.
    /// </summary>
    class VerifyPasswordValidator : IValidation
    {
        UserRecord userRecord = new UserRecord();
        
        //pattern should be password text box
        private string pattern;
        //Regular expression
        Regex regex;

        public bool Validate(string UserInput)
        {

            bool result = false;
            pattern = userRecord.UserPassword;
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
                Console.WriteLine(e);
            }
            return result;
            
        }
    }
}
