using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    public class StringValidator
    {
        IValidator _validate;
        public void StringValidatorref(IValidator validate)
        {
            this._validate = validate;
        }
        public void  ValidateStringref(string data)
        {
            bool result= this. _validate.IsValidString(data);
            Console.WriteLine(result);



        }
    }
}