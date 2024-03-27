using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Salary
    {
        static void Main(string[] args)
        {
            int basic = Convert.ToInt32(args[0]);
            int comm = Convert.ToInt32(args[1]);
            float v = basic * 0.15f;
            float hra = v;
            float da = basic * 0.30f;
            float total = basic + comm + da + hra;
            Console.WriteLine("the total salary is:"+total);
        }
    }
}

