using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    internal class passbyref3
    {
        static void Main(string[] args)
        {
            int var = 10;
            Console.WriteLine(var);
            changevar(ref var);
            Console.WriteLine(var);
        }
        public static void changevar(ref int varr)
        {
            varr = 100;
            Console.WriteLine(varr);
        }
    }
}
