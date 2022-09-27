using System;
namespace methodOverloading

{
    public class MethodOverloading
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(add(2, 5));
            Console.WriteLine(add(4.3, 2.5));
            Console.WriteLine(add(2, 34, 5));
            //method overloading
        }
    }
}

