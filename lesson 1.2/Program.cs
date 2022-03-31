using System;

namespace lesson_1._2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Please enter a number for X ");
            string xInput =Console.ReadLine();

            Console.Write("Please enter a number for Y ");
            string yInput = Console.ReadLine();

            Console.WriteLine(xInput + yInput);
            //int x = convert.Toint32(xInput);
            //int y = convert.Toint32(yInput);

            //Add(x, y);
        }
        static void Add(int x, int y =1, int z = 0)
        {
            Console.WriteLine(x + y + z);
        }
    }
}
