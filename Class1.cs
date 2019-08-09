using System;
using static System.Console;

namespace ClassExample
{
    class Rectangle
    {
        private double l;  
        private double w;  
        private double h;  
        
public void setLength (double length)
        {
            l = length;
        }
        public void setWidth (double width)
        {
            w = width;
        }
        public void setHeight (double height)
        {
            h = height;
        }

        public double getVolume()
        {
            return l * w * h;
        }
    }

    class Tester
    {
        static void Main (string[] args)
        {

            
            Rectangle rec1 = new Rectangle();
            Rectangle rec2 = new Rectangle();

            
            rec1.setLength(10.0);
            rec1.setWidth(5.5);
            rec1.setHeight(2);

            rec2.setLength(10.0);
            rec2.setWidth(5.5);
            rec2.setHeight(4);

            
            WriteLine("Area of rec1 is {0}", rec1.getVolume());
            WriteLine("Area of rec2 is {0}", rec2.getVolume());
            ReadLine();
        }
    }
}

