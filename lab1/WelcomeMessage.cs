using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class WelcomeMessage
    {
        static void Main(string[] args)
        {
            string firstname = args[0];
            string lastname = args[1];
            Console.WriteLine("welcome to Csharp(C#)" + firstname + " " + lastname);       }
    }
}
