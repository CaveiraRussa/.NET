
using System;
using static System.Console;

namespace AllAboutStrings
{

    class Program
    {

        static void Main(string[] args)
        {

            string myname = "Luiz Augusto";
            for (int i = 0; i <= myname.Length - 1; i++)
            {
                WriteLine("Letra {0} no string myname é {1}", i, myname[i]);
            }

            ReadLine();
        }
    }
}
