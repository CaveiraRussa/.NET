
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
            WriteLine("Switch exemplo.");
            Write("Digite uma letra: ");

            
            char inputChar = System.Convert.ToChar(ReadLine());
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            
            switch (inputChar)
            {
                case 'a':
                    WriteLine("A letra digitada é um a.");
                    break;

                case 'e':
                    WriteLine("A letra digitada é um e.");
                    break;

                case 'i':
                    WriteLine("A letra digitada é um i.");
                    break;

                case 'o':
                    WriteLine("A letra digitada é um o.");
                    break;

                case 'u':
                    WriteLine("A letra digitada é um u.");
                    break;

                default:
                    WriteLine("A letra digitada não é uma vogal.");
                    break;
            }
            ReadLine();
        }
    }
}

