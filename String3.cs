
using System;
using static System.Console;

namespace AllAboutStrings
{

    class Program
    {

        static void Main(string[] args)
        {

            string myname = "Luiz Augusto";
            string othername = "Nome aleatorio";

            if (String.Compare (myname, othername) == 0)
            {
                WriteLine(myname + " e " + othername + " s�o iguais.");
            }
            else
            {
                WriteLine(myname + " e " + othername+ " n�o s�o iguais.");
            }

            if (myname.Contains("Augusto"))
            {
                WriteLine("A string 'Phillips' foi encontrado na string myname");    
            }
            else
            {
                WriteLine("A string 'Phillips' n�o foi encontrado na string myname");
            }

            WriteLine("Substring exemplo com 1 parm {0}", myname.Substring(5));
            WriteLine("Substring exemplo com 2 parms {0}", myname.Substring(5,3));
            ReadLine();
        }
    }
}
