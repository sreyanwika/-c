using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_interfaces_
{
    interface fname
    {
        void firstname();

    }
    interface lname
    {
        void lastname();

    }
    class name : fname, lname
    {
        public void firstname()
        {

            Console.Write("sreya");

        }
        public void lastname()
        {

            Console.WriteLine("anwika");

        }
    }
    internal class miltiple
    {
        static void Main(string[] args)
        {
            name a = new name();
            a.firstname();
            a.lastname();
        }
    }
}
