using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    class StringValidator
    {
        Ivalidator _validate;
        public StringValidator(Ivalidator validate)
        {
            this._validate = validate;
        }
        public void  ValidateString(string data)
        {
              _validate.IsValidString(data);



        }
    }
}