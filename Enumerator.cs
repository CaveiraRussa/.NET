
using System;
using static System.Console;

namespace EnumExample
{
    class EnumProg
    {
        enum Colors { Red, Blue, Green, Black};
        enum Months { January, February, March, April, May, June, July, August, September};

        static void Main (string[] args)
        {
            int myEyes = (int)Colors.Black;
            int myBDay = (int)Months.August;

            WriteLine("Meus olhos são {0}", myEyes);
            WriteLine("Meu aniversario é em {0}", myBDay);

            ReadLine();
        }
    }
}

