using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class employee
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter your employee name:");
            string ename = Console.ReadLine();
            Console.WriteLine("enter your employee num:");
            string emnum = Console.ReadLine();
            Console.WriteLine("enter your designation:");
            string desig = Console.ReadLine();
            Console.WriteLine("enter your basic:");
            int basic = Convert.ToInt32(Console.ReadLine());
            float hra = basic * 0.15f;
            float da = basic * 0.30f;
            float total = basic + hra + da;
            Console.WriteLine("employee name is:" + ename + "\nnumber:" + emnum + "\ndesignation:" + desig + "\nbasic :" + basic + "\n total salary:" + total);
        }
    }
}
