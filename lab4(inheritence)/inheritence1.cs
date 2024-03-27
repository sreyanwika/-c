using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class vehicle
    {
        public string brand = "bmw";
        public void horn()
        {
            Console.WriteLine("Zuu Zuuu");
        }
    }
    class bike : vehicle
    {
        public string modelname = "duke";
    }
    internal class inheritence1
    {
        static void Main(string[] args)
        {
            bike a = new bike();
            Console.WriteLine("the bike brand:" + a.brand + " the modelname:" + a.modelname);
            a.horn();
        }
    }
}
