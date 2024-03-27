using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class trianArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter length of traingle:");
            int len= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth of traingle:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter height of traingle:");
            int h = Convert.ToInt32(Console.ReadLine());
            int area = len * b * h;
            Console.WriteLine("the area of  traingle is:"+area);
        }
    }
}
