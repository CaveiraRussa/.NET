
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
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            if (vowels.Contains(char.ToLower(inputChar)))
            {
                WriteLine("Character " + inputChar + " é uma vogal.");
            }
            else 
            {
                WriteLine("Character " + inputChar + "Não é uma vogal .");
                if (digits.Contains(char.ToLower(inputChar)))
                {
                    WriteLine("Character " + inputChar + " é um numero.");
                }
            }
            ReadLine();
        }
    }
}
