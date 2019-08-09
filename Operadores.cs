
using System;

class MainClass2
{
    static void Main()
    {
        double a = 5, b=6, c;
        
       
        c = a + b;
        Console.WriteLine("standard assignment c = a+b " + c + "\n");

        
        Console.WriteLine("And assign a += b " + (a += b) + "\n");

        a = 5;
        
        Console.WriteLine("Subtract assign a -= b " + (a -= b) + " \n");

        a = 5;
       
        Console.WriteLine("Multiply assign a *= b " + (a *= b) + "\n");

        a = 5;
        
        Console.WriteLine("Divide assign a /= b " + (a /= b) + "\n");

        a = 5;
       
        Console.WriteLine("Mod assign a %= b " + (a %= b) + "\n");

        Console.ReadLine();
    }
}
