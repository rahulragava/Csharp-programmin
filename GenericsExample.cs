using System;
using System.Collections.Generic;
namespace HelloWorld
{
    public class GenericsExample<T>
    {
        T[] arr ;

        public GenericsExample(int size)
        {
            arr = new T[size];
        }
        public T getItem(int index)
        {
            return arr[index];
        }
        public void setIndex(int index, T value)
        {
            arr[index] = value;
        }
    }

    public class GenericsExample
    {
        public static void Main(string[] args)
        {
            //int arr from generics
            GenericsExample<int> numArr = new GenericsExample<int>(10);
            for (int i = 0; i < 10; i++)
            {
                numArr.setIndex(i, i * 10);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(numArr.getItem(i));
            }


            //char generic arr
            GenericsExample<char> charArr = new GenericsExample<char>(10);
            for(int i = 0; i < 10; i++)
            {
                charArr.setIndex(i, (char)(i + 97));
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(charArr.getItem(i));
            }

        }
    }
}

