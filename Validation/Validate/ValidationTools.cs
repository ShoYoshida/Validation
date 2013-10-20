using System;

namespace Validation.Validate
{
    static class ValidationTools
    {
        public static bool NullCheck(string s)
        {           
            if (s == null)
            {
                Console.WriteLine("NullCheck:               [NG]");
                return false;
            }
            Console.WriteLine("NullCheck:               [OK]");
            return true;        
        }

        public static bool RequiredCheck(string s)
        {
            if (s.Length == 0)
            {
                Console.WriteLine("必須Check:               [NG]");
                return false;
            }
            Console.WriteLine("必須Check:               [OK]");
            return true;
        }

        public static bool DigitsCheck(string s,int digit)
        {
            if (s.Length > digit) 
            {
                Console.WriteLine("桁数Check:               [NG]");
                return false;
            }
            Console.WriteLine("桁数Check:               [OK]");
            return true;
        }

        public static bool NumberCheck(string s)
        {
            int o;
            if (!int.TryParse(s,out o))
            {
                Console.WriteLine("数値Check:               [NG]");
                return false;
            }
            Console.WriteLine("数値Check:               [OK]");
            return true;
        }
    }
}
