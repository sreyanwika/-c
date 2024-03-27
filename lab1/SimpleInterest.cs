using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class SimpleInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter principle amount:");
            int p= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter rate of interest:");
            float r= (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter time:");
            int t = Convert.ToInt32(Console.ReadLine());
           
            float si= (p*r*t) / 100;
            Console.WriteLine("the simple interest  is:" + si);
        }
    }
}
