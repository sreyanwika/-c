using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Animal
    {
        public virtual void soundd()
        {
            Console.WriteLine("the animal makes sound");
        }
    }
    class Dog : Animal
    {
        public override void soundd()
        {
            Console.WriteLine("the dog sounds like boww boww");
        }
    }
    class cat : Animal
    {
        public override void soundd()
        {
            Console.WriteLine("the cat sounds like meoww meoww");
        }
    }
    internal class poly
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            Animal b = new Dog();
            Animal c = new cat();
            a.soundd();
            b.soundd();
            c.soundd();
        }

    }
}
