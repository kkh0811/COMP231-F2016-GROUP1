using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PasswordApplication.Interfaces;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordApplication
{
    class NewCategoryValidator : IValidation
    {
        // create pattern to match category
        //regular expression only allows user to input alphabets,numbers,@,.,_,space only,max length is 30.
        private string pattern = "^[a-zA-Z0-9]+([1-zA-Z0-1@._\\s]{1,30})$";
        //instantiate Regular Expression
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
                MessageBox.Show("Character name cannot be empty. \nPlease input at least an alphabet,number, @, ., _");
                return false;
            }
            throw new NotImplementedException();
        }
    }
}
