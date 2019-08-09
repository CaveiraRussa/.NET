
using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;

            Console.WriteLine("a == b is {0} \n", a == b);  
            Console.WriteLine("a != b is {0} \n", a != b);  
            Console.WriteLine("a > b is {0} \n", a > b);    
            Console.WriteLine("a < b is {0} \n", a < b);    
		
            Console.WriteLine("a >= b is {0} \n", a >= b);  
            Console.WriteLine("a <= b is {0} \n", a <= b);  
            Console.ReadLine();
        }
    }
}
