
using System;
using static System.Console;
using System.Collections;

public class Program
{
    public static void Main()
    {

       
        ArrayList names = new ArrayList();
        
	names.Add("Luiz");
        names.Add("Cesar");
        names.Add("Zeca");
        names.Add("Betty");

        
        foreach (string name in names)
        {
            if (name == "Zeca")
            {
                continue;
            }
            WriteLine(name);
        }
        ReadLine();
    }
}




