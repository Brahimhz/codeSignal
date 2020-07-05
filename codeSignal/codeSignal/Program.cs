using System;

namespace codeSignal
{
    class Program
    {
        public static TheCore TheCore;
        static void Main(string[] args)
        {
            TheCore = new TheCore();

            //Console.WriteLine(TheCore.addTwoDigits(29));

            Console.WriteLine(TheCore.largestNumber(2));

            Console.ReadLine();


        }
    }
}
