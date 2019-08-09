
using System;
using static System.Console;

public class ThreeDimensions
{
    static void Main()
    {
        int[,,] threedim =
                    {
                        { { 1,2,3 }, {3,2,1 } },
                        { { 4,5,6 }, {6,5,4 } },
                        { { 7,8,9}, {9,8,7 } },
                        { {10,11,12}, {12,11,10 } }
                    };

        int dim1 = threedim.GetLength(0);
        int dim2 = threedim.GetLength(1);
        int dim3 = threedim.GetLength(2);

        WriteLine("Dimensão 0 contem {0} elementos.", dim1);
        WriteLine("Dimensão 1 contem {0} elementos.", dim2);
        WriteLine("Dimensão 2 contem {0} elementos. \n", dim3);

        for (int i1 = 0; i1 < dim1; i1++)
        {
            for (int i2 = 0; i2 < dim2; i2++)
            {
                for (int i3 = 0; i3 < dim3; i3++)
                {
                    WriteLine("threedim[{0},{1},{2}] = {3}", i1, i2, i3, threedim[i1, i2, i3]);
                }
            }
        }
        ReadLine();
    }
}
