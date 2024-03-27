using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    abstract class animal
    {
        abstract public void eat();
        public void sound()
        {
            Console.WriteLine("boww");
        }
    }
    class dog : animal
    {
        private string name;
        public dog(string name)
        {
            this.name = name;
        }
        public override void eat()
        {
            Console.WriteLine(name + " eats");
        }

    }
    internal class abstract3
    {
        static void Main(string[] args)
        {
            dog a = new dog("lulu");
            a.eat();
            a.sound();
        }
    }
}
