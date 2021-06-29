using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    class StringLengthValidator : Ivalidator
    {
        public bool IsValidString(string data)
        {

            if (data.Length > 8)
            {
                return false;
            }
            return true;
        }
}
