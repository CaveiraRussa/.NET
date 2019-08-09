using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            int  a = 5, b = 3, c;
            string person;
               
          
            a = 10;
            b = 20;
            c = a + b;
            person = "Luiz";

            Console.WriteLine("a = {0}, b = {1}, c = {2}, person = {3}", a, b, c, person);
            Console.ReadLine();
        }
    }
}
