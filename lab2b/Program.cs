namespace Lab2b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var = 10;
            Console.WriteLine(var);
            changevar(var);
            Console.WriteLine(var);
        }
        public static void changevar(int varr)
        {
            varr = 100;
            Console.WriteLine(varr);
        }
    }
}
