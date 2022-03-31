using System;

namespace classwork
{
    internal class Program
    {
        static void Main()
        {
            int x = 15;
            int y = 3;
            Add(x, y);
            Subtract(x, y);
            Multiply(x, y);
            Divide(x, y);
        }
        static void Add(int x, int y)
        {
            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
        }
        static void Subtract(int x, int y)
        {
            Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
        }
        static void Multiply(int x, int y)
        {
            Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
        }
        static void Divide(int x, int y)
        {
            Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
        }
    }
}
