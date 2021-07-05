using System;

namespace StringValidatorProgramme
{
    class Program
    {
        static void Main(string[] args)
        {
            NullorEmptyString _nulloremptystring = new NullorEmptyString();
            StringLengthValidator _stringlengthvalidator = new StringLengthValidator();
            StringCheckEx _stringcheckex = new StringCheckEx();

            StringValidator _stringvalidator = new StringValidator();
            _stringvalidator.StringValidatorref(_nulloremptystring);
            _stringvalidator.ValidateStringref("");

            _stringvalidator.StringValidatorref(_stringlengthvalidator);
            _stringvalidator.ValidateStringref("GoodMorning");

            _stringvalidator.StringValidatorref(_stringcheckex);
            _stringvalidator.ValidateStringref("Excellent");



        }
    }
}
