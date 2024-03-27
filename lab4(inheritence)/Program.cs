namespace Lab4
{
    class Animal
    {
        public void Eat(string name)
        {
            Console.Write(name+"\tEatss");
        }
    }
    //single inheritence
    class Dog : Animal
    {
        public void bark()
        {
            Console.WriteLine("\tbarks");
        }
    }
    //hierarchial inheritence
    class bird : Animal
    {
        public void fly()
        {
            Console.WriteLine("\tflies");
        }
    }
    //multilevel inheritence
    class horse : Animal
    {
        public void runs()
        {
            Console.Write("\truns");
        }
    }
    class cheetah : horse
    {
        public void carnivore()
        {
            Console.WriteLine("\tcarnivore");
        }
    }
    //multiple inheritence
    interface hospital
    {
         void consult();
    }
    interface medical
    {
         void medicine();
    }
    class bill : hospital, medical
    {
        public void consult()
        {
            Console.WriteLine("consulted doctor");
        }
        public void medicine()
        {
            Console.WriteLine("doctor suggested ");
        }
        public void amount()
        {
            Console.WriteLine("bill is cleared ");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //creating instance for single inheritence
            Dog a = new Dog();
            a.Eat("golden  retriever");
            a.bark();
            //creating instance for hierarchial inheritence
            bird b = new bird();
            b.Eat("parrot");
            b.fly();
            //creating instance for multi level inheritence
            cheetah c = new cheetah();
            c.Eat("lep");
            c.runs();
            c.carnivore();
            //creating instance for multip[le  inheritence
            bill d = new bill();
            d.consult();
            d.medicine();
            d.amount();
        }
    }
}
