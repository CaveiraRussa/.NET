
using System;
using static System.Console;

public class Program
{
    public static void Main()
    {
        
        int[] Scores = new int[] { 105, 92, 81, 93, 100 };
        int MyScore;

        
        for (int i = 0; i < 5; i++)
        {

            
            MyScore = Scores[i];

            switch (MyScore)
            {
                case 105:
                    WriteLine("Pontuação do teste foi 105.");
                    break;
                case 92:
                    WriteLine("Pontuação do teste fois 92.");
                    break;
                case 81:
                    WriteLine("Pontuação do teste foi 81.");
                    break;
                default:
                    WriteLine("Pontuação do teste não foi 105, 92 ou 81.");
                    break;
            }
        }
        ReadLine();
    }
}

