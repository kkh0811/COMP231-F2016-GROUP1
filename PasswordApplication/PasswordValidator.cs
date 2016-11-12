﻿using PasswordApplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using PasswordApplication.Model;

namespace PasswordApplication
{
    class PasswordValidator : IValidation
    {
        //string pattern to match
        private string pattern = "(?=^.{2,255}$)((?=.*\\d)(?=.*[A-Z])"
            + "(?=.*[a-z])|(?=.*\\d)(?=.*[^A-Za-z0-9])(?=.*[a-z])|(?=.*[^A-Za-z0-9])(?=.*[A-Z])(?=.*[a-z])|"+
            "(?=.*\\d)(?=.*[A-Z])(?=.*[^A-Za-z0-9]))^.*";
        //instantiate Regular Expression
        Regex regex;

        public bool Validate(string UserInput)
        {
            bool result = false;
            //create obj regex and pattern is the string pattern
            regex = new Regex(pattern);
            try
            {   //regex matches user input to string
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
