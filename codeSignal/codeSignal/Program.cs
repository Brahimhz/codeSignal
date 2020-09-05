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

            //Console.WriteLine(TheCore.largestNumber(2));

            //Console.WriteLine(3/9);

            // Console.WriteLine(TheCore.seatsInTheater(13,6,8,3));

            //Console.WriteLine(TheCore.circleOfNumbers(10,7));

            //Console.WriteLine(TheCore.lateRide(808));

            //Console.WriteLine(TheCore.phoneCall(1,2,1,6));

            Console.WriteLine(TheCore.reachNextLevel(16, 23, 16));

            Console.ReadLine();


        }
    }
}
