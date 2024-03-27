using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class virtualproperty
    {
        static void Main(string[] args)
        {
            encapp a = new encapp();
            a.name = "sreya";
            Console.WriteLine("the name of student is:" + a.name);
        }
    }
}
public class encapp
{
    private string student_name="sreya";
    public string name
    {
        get { return student_name; }
        set { student_name = value; ; }
    }
    
}

