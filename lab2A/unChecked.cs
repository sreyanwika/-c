using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class unChecked
    {
        static void Main(string[] args)
        {
            unchecked
            {
                int v = int.MaxValue;
                Console.WriteLine("the checked value is:" + (v + 2));
            }
        }
    }
}
