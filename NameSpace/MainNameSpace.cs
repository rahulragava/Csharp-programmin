using System;
using First;
//using Second;   **It will give ambiguity when there is multiple namespace used since it can have same class name or interface
namespace HelloWorld
{
    public class MainNameSpace
    {
        public static void Main()
        {
            NameSpaceExample nse = new NameSpaceExample();
            nse.nameSpaceExample();
            Second.NameSpaceExample nse2 = new Second.NameSpaceExample();
            nse2.nameSpaceExample();
        }
    }
}

