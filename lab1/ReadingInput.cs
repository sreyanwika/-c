using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ReadingInput { 
        static void Main(string[] args)

    {
            Console.WriteLine("enter your first name:");
            string firstname = Console.ReadLine();
            Console.WriteLine("enter your last name:");
            string lastname = Console.ReadLine();
            Console.WriteLine("enter your rollnum:");
            string rollnum = Console.ReadLine();
            Console.WriteLine("enter your sem:");
            string sem= Console.ReadLine();
            Console.WriteLine("enter your specializaton:");
            string spec = Console.ReadLine();
            Console.WriteLine("your name is:" + firstname + " " + lastname + "\nrollnum:" + rollnum + "\nsem:" + sem + "\nspecialization:" + spec);
    }
}

    }

