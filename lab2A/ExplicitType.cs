using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class ExplicitType
    {
        static void Main(string[] args)
        {

/*explit type conversion*/
            double i = 11.44d;
            float j = (float)i;
            long  k = (long)j;
            int l = (int)k;
            Console.WriteLine("the converted integer numb is:" + l);
            Console.WriteLine("the converted  long of numb is:" + k);
            Console.WriteLine("the converted  float of numb is:" + j);
            Console.WriteLine("the double numb is:" + i);
        }
    }
}
