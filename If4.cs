

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
            WriteLine("Exemplo if");
            Write("Digite uma letra: ");

            
            char inputChar = System.Convert.ToChar(ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

           
            if (vowels.Contains(char.ToLower(inputChar)))
            {
                WriteLine("Character " + inputChar + " � uma vogal.");
            }
            else if (char.ToLower(inputChar) == 'a')
            {
                WriteLine("Character " + inputChar + " � um a.");
            }
            else if (char.ToLower(inputChar) == 'e')
            {
                WriteLine("Character " + inputChar + " � um e.");
            }
            else if (char.ToLower(inputChar) == 'i')
            {
                WriteLine("Character " + inputChar + " � um i.");
            }
            else if (char.ToLower(inputChar) == 'o')
            {
                WriteLine("Character " + inputChar + " � um o.");
            }
            else if (char.ToLower(inputChar) == 'u')
            {
                WriteLine("Character " + inputChar + " � um u.");
            }
            else
            {
                WriteLine("Character " + inputChar + " N�o � vogal.");
            }
            ReadLine();
        }
    }
}
