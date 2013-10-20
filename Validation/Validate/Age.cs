using System;

namespace Validation.Validate
{
    class Age : IValidation
    {
        private readonly string _s;

        public Age(string s) 
        {
            this._s = s;
        }

        public void Validate()
        {
            Console.WriteLine("Age:" + _s);
            if (!ValidationTools.NullCheck(_s))
            {
                throw new Exception("Age:Nullエラー " + _s);
            };

            if (!ValidationTools.DigitsCheck(_s, 3))
            {
                throw new Exception("Age:桁数エラー " + _s);
            };

            if (!ValidationTools.NumberCheck(_s))
            {
                throw new Exception("Age:数値エラー " + _s);
            };
        }
    }
}
