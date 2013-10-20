using System;

namespace Validation.Validate
{
    class Remarks : IValidation
    {
        private readonly string _s;

        public Remarks(string s) 
        {
            this._s = s;
        }

        public void Validate()
        {
            Console.WriteLine("Remarks:" + _s);           
            if (!ValidationTools.DigitsCheck(_s, 20))
            {
                throw new Exception("Remarks:桁数エラー " + _s);
            };
         }
    }
}
