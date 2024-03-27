using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class marksAverage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter sub1 marks:");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub2 marks:");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub3 marks:");
            int sub3= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub4 marks:");
            int sub4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter sub5 marks:");
            int sub5 = Convert.ToInt32(Console.ReadLine());
            float avg = (sub1+sub2+sub3+sub4+sub5)/5;
            Console.WriteLine("the avg of 5 marks of student is:" + avg);
        }
    }
}
