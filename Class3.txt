
using System;
using static System.Console;

namespace ClassExample
{
    class Person
    {
        private string fn;  // first name
        private string ln;  // last name
        private DateTime dob;  // date of birth
        private string g;  // gender
        private double w;  // weight
        private double h;  // height 

      
        public Person 
            (
                string FirstName,
                string LastName,
                DateTime DateOfBirth,
                string Gender,
                double Weight,
                double Height
            )
            {
                WriteLine("Objeto pessoa sendo criado.");
                fn = FirstName;
                ln = LastName;
                dob = DateOfBirth;
                g = Gender;
                w = Weight;
                h = Height;
            }

        public string getFirstName()
        {
            return fn;
        }

        public string getLastName()
        {
            return ln;
        }

        public DateTime getDateOfBirth()
        {
            return dob;
        }

        public string getGender()
        {
            return g;
        }

        public double getWeight()
        {
            return w;
        }

        public double getHeight()
        {
            return h;
        }

        private bool IsAFatty()
        {

            if (w / h > 2.25)  
                return true;
            else
                return false;
        }

        public bool FailsBMI()
        {
            return IsAFatty();
        }
    }

    class Tester
    {
        static void Main (string[] args)
        {
            DateTime myBDay = new DateTime(1998, 8, 27);
            string lgender;

            Person p1 = new Person(FirstName:"Luiz", LastName:"Augusto", 										DateOfBirth:myBDay, Gender:"Male", Weight:205, Height:72);
            Person p2 = new Person(LastName: "Aleatorio", FirstName: "Nome", Weight: 215, 							Height: 76, Gender: "Male", DateOfBirth: myBDay);
            lgender = p1.getGender();

            WriteLine("{0} {1}", p2.getFirstName(), p2.getLastName());

            if (p2.FailsBMI() & lgender.Equals("Male"))
                WriteLine("Needs to increase his exercise or decrease his calories.");
            else if (p2.FailsBMI() & lgender.Equals("Female"))
                WriteLine("Needs to increase her exercise or decrease her calories.");
            else 
                WriteLine("Doing great, keep up the good work.");

            ReadLine();
        }
    }
}
