using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    sealed class student
    {
        public void attendance()
        {
            Console.WriteLine("student attenteded");
        }
    }
    /* class parent : student
     {
       throws error...
     }*/
    internal class sealedkeyword
    {
        static void Main(string[] args)
        {

            student a = new student();
            a.attendance();
        }
    }
}
