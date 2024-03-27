using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class shapee
    {
        abstract public double area();
        abstract public double perimeter();
    }
    class rectangle : shapee
    {
        private double height;
        private int width;
        public rectangle(double height,int width){
            this.height = height;
            this.width = width;
            }
        public override double area()
        {
            return width*height;
        }
        public override double perimeter()
        {
            return 2 * (width+height);
        }
    }
    internal class abstract2
    {
        static void Main(string[] args)
        {
            rectangle a = new rectangle(11.66, 16);
            double recarea = a.area();
            double recperi = a.perimeter();
            Console.WriteLine("the area of the rectangle  is:" + recarea);
            Console.WriteLine("the perimeter of the rectangle is:" + recperi);
        }
        }
}
