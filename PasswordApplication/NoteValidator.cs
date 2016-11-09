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
    /// Class validates that the note text box is correct
    /// </summary>
    class NoteValidator : IValidation
    {
        //pattern
        private string pattern = "^([1-zA-Z0-1@.\\s]{1,255})$";
        Regex regex;
        

        public bool Validate(string UserInput)
        {
           
            regex = new Regex(pattern);
            if (regex.Match(UserInput).Success)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
