using System;

namespace StringValidatorProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            NullorEmptyString value1 = new NullorEmptyString();
            StringValidator _validate1 = new StringValidator(value1);
            _validate1.ValidateString(null);

            StringCheckEx value2 = new StringCheckEx();
            StringValidator _validate2 = new StringValidator(value2);
            _validate2.ValidateString("example");

            StringLengthValidator value3 = new StringLengthValidator();
            StringValidator _validate3 = new StringValidator(value3);
            _validate2.ValidateString("enumeration");



            //StringValidator _validator = new StringValidator();
            //string data = null;
            //bool isValid = _validator.IsValidString(null);
            //bool _isValid = _validator.IsValidString("");
            //bool __isValid = _validator.IsValidString("excel");
        }
    }
}
