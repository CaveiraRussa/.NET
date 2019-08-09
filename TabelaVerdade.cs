
using System;

    public class MainClass
{
    public static void Main(string[] args)
    {

        bool p, q;

        /* table header */
        Console.WriteLine("P \t Q \t AND \t OR \t XOR \t NOT(P) \n");


        p = true; q = true;
        Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

        p = true; q = false;
        Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

        p = false; q = true;
        Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

        p = false; q = false;
        Console.WriteLine(p + "\t" + q + "\t" + (p & q) + "\t" + (p | q) + "\t" + (p ^ q) + "\t" + (!p));

        Console.ReadLine();
    }
}



