
using System;

namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20, c0, c1;
            double c2, c3, c4, c5;

            c0 = b + a;		
            c1 = b - a;		
            c2 = b / a;		
            c3 = b * a;		
            c4 = b % a;		
            c5 = Math.Pow(b, a);  

            
            Console.WriteLine("b+a={0}, b-a={1}, b/a={2}, b*a={3}, b%a={4}, " +
                                "Math.Pow(b,a)={5}", c0, c1, c2, c3, c4, c5);
            Console.ReadLine();
        }
    }
}
