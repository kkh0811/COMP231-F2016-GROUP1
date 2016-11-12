using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordApplication.Interfaces
{
    /// <summary>
    /// Use to validate any user input.
    /// Require user input string any validation pattern
    /// Return bool if the validation is pass or not.
    /// Any class implement can validate any kind of input.
    /// ex.
    /// class Validator : IValidation
    /// {
    ///     public bool Validate(UserRecord.UserName,AvoidInjectionPattern);
    /// }
    /// </summary>
    interface IValidation
    {   
        bool Validate(string UserInput);
      
    }
}
