
using System;
using static System.Console;

public class TwoDimensions
{
    static void Main()
    {
        int[,] twodim = new int[,] { { 1, 2, 3 }, { 9, 8, 7 } };

        int dim1 = twodim.GetLength(0);
        int dim2 = twodim.GetLength(1);

        WriteLine("Dimensão 0 contem {0} elementos.", dim1);
        WriteLine("Dimensão 1 contem {0} elementos.\n", dim2);

        for (int i1=0; i1 < dim1; i1++)
        {
            for (int i2=0; i2 < dim2; i2++)
            {
                WriteLine("twodim[{0},{1}] = {2}", i1, i2, twodim[i1,i2]);
            }
        }
        ReadLine();
    }
}
