using System.Net.Http.Headers;

namespace ioos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] mf = new string[] { "sreya", "harsh", "affu", "poo" };
            using(StreamWriter sw=new StreamWriter("mf.txt"))
            {
                foreach(string s in mf) {
                sw.WriteLine(s);
                }
            }
            //string line = "";
            using(StreamReader sr=new StreamReader("mf.txt"))
            {
                while (sr.Peek() > -1)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            Console.ReadLine();
            
        }
    }
}
