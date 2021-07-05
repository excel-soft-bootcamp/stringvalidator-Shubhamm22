using System;
using System.Collections.Generic;
using System.Text;

namespace StringValidatorProgramme
{
    class NullorEmptyString : IValidator
    {
        public bool IsValidString(string data)
        {

            if (string.IsNullOrEmpty(data))
            {
                return true;
               
            }
           
            
                return false;
            
        }
    }
}
