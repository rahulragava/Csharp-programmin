using System;
namespace encapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("asdf", "adsf", "g");
            Movie shrek = new Movie("asdf", "adsf", "u");
            Console.WriteLine(shrek.Rating);
            Console.WriteLine(avengers.Rating);
            avengers.Rating = "pen";
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}

