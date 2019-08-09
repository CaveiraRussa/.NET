
using System.Collections.Generic;
using System.Linq;
using static System.Console;
using static System.Convert;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("if statement example.");
            Write("Enter a character: ");

            /* cast the unspecified input datatype to a character datatype */
            char inputChar = System.Convert.ToChar(ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            /* here is the flow control */
            if (char.ToLower(inputChar) == 'a')
            {
                WriteLine("Character " + inputChar + " is a vowel.");
            }
            else if (char.ToLower(inputChar) == 'e')
            {
                WriteLine("Character " + inputChar + " is a vowel.");
            }
            else if (char.ToLower(inputChar) == 'i')
            {
                WriteLine("Character " + inputChar + " is a vowel.");
            }
            else if (char.ToLower(inputChar) == 'o')
            {
                WriteLine("Character " + inputChar + " is a vowel.");
            }
            else if (char.ToLower(inputChar) == 'u')
            {
                WriteLine("Character " + inputChar + " is a vowel.");
            }
            else
            {
                WriteLine("Character " + inputChar + " is not a vowel.");
            }
            ReadLine();
        }
    }
}
