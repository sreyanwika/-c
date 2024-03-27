using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2A
{
    internal class Checked
    {
        static void Main(string[] args)
        {
            checked
            {
                int v = int.MaxValue;
                Console.WriteLine("the checked value is:" + (v + 2));
            }
        }
    }
}
