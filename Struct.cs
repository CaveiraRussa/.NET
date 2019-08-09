
using System;
using static System.Console;

struct People
{
    private int ID;
    private string fname;
    private string lname;
    private int age;
    private string gender;

    public void getValues(int i, string f, string l, int a, string g)
    {
        ID = i;
        fname = f;
        lname = l;
        age = a;
        gender = g;
    }

    public void displayValues()
    {
        WriteLine("ID = {0}", ID);
        WriteLine("Primeiro Nome = {0}", fname);
        WriteLine("Ultimo Nome = {0}", lname);
        WriteLine("Idade = {0}", age);
        WriteLine("Genero = {0}", gender);
    }

    public class playTheGame
    {
        public static void Main(string[] args)
        {
            
            People person1 = new People();
            People person2 = new People();

           
            person1.getValues(0, "Luiz", "Augusto", 20, "Masculino");

            
            person2.getValues(1, "Nome", "Aleatorio", 22, "Female");

            
            person1.displayValues();
            WriteLine(" ");
            person2.displayValues();
            WriteLine(" ");

          
          
          
            if (person1.lname == person2.lname)
            {
                WriteLine("Porque usar um struct?");
            }

            ReadLine();
        }
    }
}
