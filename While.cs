
using System;
using static System.Console;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
		 
            Random r = new Random();
            int newRandom, counter = 0;

            while (counter < 5)
            {
                
                newRandom = r.Next(0, 100);

                WriteLine("Numero aleatorio " + counter + " foi " + newRandom);

                counter += 1;
            }
            ReadLine();
        }
    }
}
