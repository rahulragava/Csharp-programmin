using System;
namespace HelloWorld.structure
{
    public struct perimeterOfRectangle
    {
        int length, width;

        public perimeterOfRectangle(int length, int width)  //if there is no parameter or default constructor it wont work
        {
            this.length = length;
            this.width = width;
        }
        public int getPerimeter()
        {
            return 2 * (length + width);
        }
    }
}

