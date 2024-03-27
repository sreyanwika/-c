using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{

    public class RefPassByValue
    {
        public int refff
        {
            get; set;
        }
        public static void Main(string[] args)
        {
            RefPassByValue my = new RefPassByValue();
            my.refff = 10;
            Console.WriteLine(my.refff);
            changereff(my);
            Console.WriteLine(my.refff);
            Console.Read();
        }

        public static void changereff(RefPassByValue rf)
        {
            //rf = null;
          rf.refff = 200;
          Console.WriteLine(rf.refff);
        }
    }
}

