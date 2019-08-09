
using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
        int[] Scores = new int[] { 105, 92, 81, 93, 100 };
        int counter = 0;

       
        foreach (int myscore in Scores)
        {
            WriteLine("O " + counter + " index do array contem " + myscore);
            counter++;
        }
        ReadLine();
    }
}
