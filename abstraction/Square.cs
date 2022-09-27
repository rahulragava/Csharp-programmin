using System;
namespace HelloWorld
{
    public class Square : AreaClass
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }

        public override int calculateArea()
        {
            //throw new NotImplementedException();
            return side * side;
        }
    }
}

