using System;

namespace Array
{
    internal class Program
    {
        static void Main()
        {
            int[] number = new int[7] { 2, 4, 8, 1, 77, 4, 8 };
            int d = number[5] + 5;
            number[5] = d;
            number[3] = number[3] + 1;
            bool[] boolArray = new bool[3] {true, true, false};
            Console.WriteLine(number[0]);
            Console.WriteLine(number[1]);
            Console.WriteLine(number[2]);
            Console.WriteLine(number[3]);
            Console.WriteLine(number[4]);
            Console.WriteLine(number[5]);
            Console.WriteLine(number[6]);
            Console.WriteLine(boolArray[2]);
        }
    }
}
