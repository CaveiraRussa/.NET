
using System;
using static System.Console;

public class jaggedArray
{
    static void Main()
    {

       
        int[][] jaggedArray = new int[4][];

        
        jaggedArray[0] = new int[2] { 7, 9 };
        jaggedArray[1] = new int[4] { 12, 42, 26, 38 };
        jaggedArray[2] = new int[6] { 3, 5, 7, 9, 11, 13 };
        jaggedArray[3] = new int[1] { 4 };

        
        for (int i1=0; i1 < jaggedArray.Length; i1++)
        {
            Write("jaggedArray[" + i1 + "] = {");

            for (int i2=0; i2 < jaggedArray[i1].Length; i2++)
            {
                if (i2 < jaggedArray[i1].Length - 1)
                {
                    Write(jaggedArray[i1][i2] + ",");
                }
                else
                {
                    WriteLine(jaggedArray[i1][i2] + "}");
                }
            }
        }
        ReadLine();
    }
}
