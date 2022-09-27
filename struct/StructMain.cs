using System;
namespace HelloWorld.structure
{
    public class StructMain
    {
        public static void Main(string[] args)
        {
            perimeterOfRectangle por = new perimeterOfRectangle(2, 4);
            Console.WriteLine(por.getPerimeter());

        }
    }
}

