
using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
        int counter = 0;

        do
        {
            WriteLine("Valor do contador é {0}", counter);
            counter++;
        } while (counter < 4);
        ReadLine();
    }
}
