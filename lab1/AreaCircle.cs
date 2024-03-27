using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class AreaCircle
    {
        static void Main(string[] args)
        {
            float radius = (float)Convert.ToDecimal(args[0]);
            float area = 22.7f * (radius * radius);
            Console.WriteLine("the area of circle is:" + area);
        }
    }
}
