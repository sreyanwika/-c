using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class implicitType
    {
        static void Main(string[] args)
        {
            int i= 11;
            long j = i;
            float k = j;
            double l = k;
            Console.WriteLine("the integer numb is:"+i);
            Console.WriteLine("the long of numb is:" + j);
            Console.WriteLine("the float of numb is:" + k);
            Console.WriteLine("the double numb is:" + l);
        }
    }
}
