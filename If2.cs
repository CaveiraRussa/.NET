
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
            WriteLine("Exemplo if.");
            Write("Digite uma letra: ");

           
            char inputChar = System.Convert.ToChar(ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            
            if (vowels.Contains(char.ToLower(inputChar)))
            { 
                WriteLine("Character "  + inputChar + " é vogal.");
            }
            else
            {
                WriteLine("Character " + inputChar + " não é vogal.");
            }
            ReadLine();
        }
    }
}

