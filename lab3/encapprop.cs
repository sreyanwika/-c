using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class encapprop
    {
        static void Main(string[] args)
        {
            propp a = new propp();
            a.name = null;
            a.age = 20;
            Console.WriteLine("the name of the student is:" + a.name + "the age of the student is:"+a.age);
            a.marks = 100;
            Console.WriteLine("the name of the student is:" + a.marks);
        }
    public class propp
    {
        public string name;
        public int age;
        private int marks;
    }
}
