

using System;
using static System.Console;

namespace AllAboutStrings
{

    class Program
    {

        static void Main(string[] args)
        {

            string notinitialized = null;
            string initializedtoblank = "";
            string myname = "Luiz Augusto";

            WriteLine("notinitialized IsNullOrEmpty {0}", 							               			string.IsNullOrEmpty(notinitialized));
            WriteLine("initializedtoblank IsNullOrEmpty {0}", 									string.IsNullOrEmpty(initializedtoblank));
            WriteLine("myname IsNullOrEmpty {0}", string.IsNullOrEmpty(myname));

            ReadLine();
        }
    }
}


