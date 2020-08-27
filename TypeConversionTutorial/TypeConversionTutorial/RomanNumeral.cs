using System;
namespace TypeConversionTutorial
{
    public class RomanNumeral
    {
        //note that I copied the comments so I can use this for future reference
        private int value;
        public RomanNumeral(int value)
        {
            this.value = value;
        }
        // Declare a conversion from an int to a RomanNumeral. Note the
        // the use of the operator keyword. This is a conversion
        // operator named RomanNumeral:
        static public implicit operator RomanNumeral(int value)
        {
            // Note that because RomanNumeral is declared as a struct,
            // calling new on the struct merely calls the constructor
            // rather than allocating an object on the heap:
            return new RomanNumeral(value);
        }
        // Declare an explicit conversion from a RomanNumeral to an int:
        static public explicit operator int(RomanNumeral roman)
        {
            return roman.value;
        }
        // Declare an implicit conversion from a RomanNumeral to
        // a string:
        static public implicit operator string(RomanNumeral roman)
        {
            // storing roman values of digits from 0-9  
            // when placed at different places 
            String[] m = { "", "M", "MM", "MMM" };
            String[] c = {"", "C", "CC", "CCC", "CD", "D",
                            "DC", "DCC", "DCCC", "CM"};
            String[] x = {"", "X", "XX", "XXX", "XL", "L",
                            "LX", "LXX", "LXXX", "XC"};
            String[] i = {"", "I", "II", "III", "IV", "V",
                            "VI", "VII", "VIII", "IX"};

            // Converting to roman 
            String thousands = m[roman.value / 1000];
            String hundereds = c[(roman.value % 1000) / 100];
            String tens = x[(roman.value % 100) / 10];
            String ones = i[roman.value % 10];

            String ans = thousands + hundereds + tens + ones;

            return ans;
        }

        public static implicit operator RomanNumeral(BinaryNumeral binary)
        {
            int value = (int)binary;
            RomanNumeral r = new RomanNumeral(value);
            return r.value;
            
        }
    }
}
