namespace Lab4_interfaces_
{
    interface animal
    {
        void eats();
        void sleeps();
        
    }
    class elephant : animal
    {
        public void eats()
        {
            
                Console.WriteLine("it eats!");
            
        }
        public void sleeps()
        {

            Console.WriteLine("it sleeps!");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            elephant a = new elephant();
            a.eats();
            a.sleeps();
        }
    }
}
