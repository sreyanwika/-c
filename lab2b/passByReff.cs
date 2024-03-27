using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    internal class passByReff
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
                changereff(ref my);
                Console.WriteLine(my.refff);
                Console.Read();
            }

            public static void changereff(ref RefPassByValue rf)
            {
                //rf = null;
                rf.refff = 200;
                Console.WriteLine(rf.refff);
            }
        }
    }
