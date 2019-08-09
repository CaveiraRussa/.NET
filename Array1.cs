
using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
       
        int[] Scores = new int[] { 105, 92, 81, 93, 100 };

       
        for (int i = 0; i < 5; i++)
        {
            WriteLine("The " + i + " index do array contem " + Scores[i]);
        }
        ReadLine();
    }
}
