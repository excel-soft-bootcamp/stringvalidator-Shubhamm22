using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    class StringCheckEx:IValidator
    {
        public bool IsValidString(string data)
        {

            if (data.StartsWith("ex"))
            {
                return true;
            }
            
            
                return false;
            
        }
    }
}
