using System;
namespace HelloWorld
{
    public class Circle : AreaClass
    {
        double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public override int calculateArea()
        {
            //throw new NotImplementedException();
            return (int)(Math.PI * radius * radius);
        }
    }
}

