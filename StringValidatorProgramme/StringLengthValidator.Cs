using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    class StringLengthValidator : IValidator
    {
        public bool IsValidString(string data)
        {

            if (data.Length > 8)
            {
                return true;
            }
            return false;
        }
    }
}
