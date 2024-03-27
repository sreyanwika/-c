namespace Lab5
{
    abstract class shape {
        abstract public  double area();
    }
    class circle : shape
    {
        private int radius = 10;
        public override double area()
        {
            return Math.PI * (radius * radius);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle a = new circle();
            double carea=a.area();
            Console.WriteLine("the area of the circle is:" + carea);
        }
    }
}
