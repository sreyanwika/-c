namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            encap a = new encap();
            a.name = "sreya";
            a.age = "20";
            Console.WriteLine("the name of student is:"+a.name);
            Console.WriteLine("the age of student is:" + a.age);
        }
    }
    public class encap
    {
        private string student_name;
        private string student_age;
        public string name { get { return student_name; }
            set { student_name = value; ; }
        }
        public string age
        {
            get { return student_age; }
            set { student_age = value; ; }
        }
    }
}
