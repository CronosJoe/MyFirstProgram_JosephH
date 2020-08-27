using System;

namespace TypeConversionTutorial
{
    class MainClass
    {
        static void Main(string[] args)
        {

            RomanNumeral numeral;
            numeral = 10;
            //int
            Console.WriteLine((int)numeral);
            //string
            Console.WriteLine(numeral);
            
            short s = (short)numeral;
            Console.WriteLine(s);

            BinaryNumeral number;
            number = 10;
            //int
            Console.WriteLine((int)number);
           //string
            Console.WriteLine(number);
           
            short t = (short)number;

            
            Console.WriteLine(t);

            RomanNumeral roman;
            roman = 10;
            BinaryNumeral binary;
            // Perform a conversion from a RomanNumeral to a
            // BinaryNumeral:
            binary = (BinaryNumeral)(int)roman;
            // Performs a conversion from a BinaryNumeral to a RomanNumeral.
            // No cast is required:
            roman = binary;
            Console.WriteLine((int)binary);
            Console.WriteLine(binary);
            Console.ReadKey();
        }
    }

    
}
