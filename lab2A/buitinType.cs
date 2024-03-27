using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class buitinType
    {
        /*performing explict conversion using built-in methods
         */
        static void Main(string[] args)
        {
            char c = 'a';
            double l = 11.66d;
            Console.WriteLine("the integer numb is:" + Convert.ToInt32(c));
            Console.WriteLine("the integer numb is:" + Convert.ToInt32(l));
            Console.WriteLine("the long of numb is:" + Convert.ToInt64(l));
            Console.WriteLine("the float of numb is:" + Convert.ToDecimal(l));
            Console.WriteLine("the string  numb is:" + Convert.ToString(l));
            Console.WriteLine("the boolean conversion of numb is:" + Convert.ToBoolean(l));
        }
    }
}
