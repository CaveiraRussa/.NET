
using System;
using static System.Console;

namespace AllAboutStrings
{

    class Program
    {

        static void Main(string[] args)
        {

            
            string literal1, literal2, literal3;
            literal1 = "Hello";
            literal2 = " ";
            literal3 = "World";
            WriteLine("From string literal(s) " + literal1 + literal2 + literal3);

            
            char[] helloworld = { 'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd' };
            string firstprog = new string(helloworld);
            WriteLine("From the string constructor new {0}", firstprog);

            
            string newmessage = string.Join("", helloworld);
            WriteLine("From a method which returns a string {0}", newmessage);

            
            DateTime currenttime = new DateTime(2018, 11, 19, 9, 31, 1);
            string mytime = String.Format("The current date and time are {0:D} {0:t}", currenttime);
            WriteLine("{0}", mytime);


            ReadLine();
        }
    }
}


