
using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 3, c;
            string person;
            double pi = 3.14159;
	     	 bool   t_or_f = false;

            
            a = 10;
            b = 20;
            c = a + b;
            person = "Luiz";

            Console.WriteLine("a = {0}, b = {1}, c = {2}, person = {3}, pi = {4},t_or_f = {5}", 
						a, b, c, person, pi, t_or_f);
            Console.ReadLine();
        }
    }
}
