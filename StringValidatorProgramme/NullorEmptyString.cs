using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    class NullorEmptyString : Ivalidator
    {
        public bool IsValidString(string data)
        {

            if (string.IsNullOrEmpty(data))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
